using BusinessData;
using BusinessData.ofDataAccessLayer.ofCommon;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory
{
    public class CommodityFileFactory<TEntity> : EntityFileFactory<TEntity>, ICommodityFileFactory<TEntity> where TEntity : Commodity, new()
    {
        public Dictionary<string, List<TEntity>> SetExcelCommodities(object[,] datas, Dictionary<PropertyInfo, int> Target, int CenterTarget)
        {
            var properties = typeof(TEntity).GetProperties();
            Dictionary<string, List<TEntity>> keyValuePairs = new Dictionary<string, List<TEntity>>();
            List<TEntity> entities = new();
            var Keys = Target.Keys;
            int i = 2;
            try
            {
                while (datas[i, 2] != null)
                {
                    TEntity entity = new();
                    foreach (var key in Keys) // Excel To Entity
                    {
                        foreach (var prop in properties)
                        {
                            if (key.Equals(prop))
                            {
                                prop.SetValue(entity, datas[i, Target[key]].ToString());
                                break;
                            }
                        }
                    }
                    var findentity = entities.Find(e => e.Equals(entity));
                    if (findentity == null) // 중복성 체크
                    {
                        entities.Add(entity);
                        string CenterCode = datas[i, CenterTarget].ToString();
                        // UserCode 라는 Key가 있는지 확인
                        bool IsContain = keyValuePairs.ContainsKey(CenterCode);
                        if (IsContain)
                        {
                            var values = keyValuePairs[CenterCode];
                            values.Add(entity);
                            i++;
                        }
                        else
                        {
                            keyValuePairs.Add(CenterCode, new List<TEntity>() { entity });
                            i++;
                        }
                    }
                    else
                    {
                        entity = null;
                        i++;
                    }
                }
            }
            catch
            {
                Application.Workbooks.Close();
                Application = null;
                return keyValuePairs;
            }
            Application.Workbooks.Close();
            Application = null;
            return keyValuePairs;
        }
    }
}
