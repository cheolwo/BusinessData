using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory
{
    public interface IEntityFileFactory
    {

    }
    public interface IEntityPDFFileFactory
    {

    }
    public interface IEntityExcelFileFactory
    {
    }
    public interface IEntityFileFactory<TEntity> : IEntityFileFactory where TEntity : Entity
    {
        object[,] InitExcelData(string fileconnection);
        List<TEntity> SetExcelEntities(object[,] datas, Dictionary<PropertyInfo, int> Target);
    }
    public interface IEntityExcelFileFactory<TEntity> : IEntityExcelFileFactory where TEntity : Entity
    {
        Task<FileStream> ConvertToFileStream(TEntity entity, string nameofFile);
    }
    public interface ICenterFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Center
    {
        Dictionary<string, List<TEntity>> SetExcelCenters(object[,] datas, Dictionary<PropertyInfo, int> Target, int UserTarget);
    }
    public interface ICommodityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity
    {
        Dictionary<string, List<TEntity>> SetExcelCommodities(object[,] datas, Dictionary<PropertyInfo, int> Target, int CenterTarget);
    }
    public class EntityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity, new()
    {
        protected Application Application { get; set; }
        protected Workbook Workbook { get; set; }
        protected Worksheet Worksheet { get; set; }
        public EntityFileFactory()
        {
        }
        public object[,] InitExcelData(string fileconnection)
        {
            Application = new Application();
            Workbook = null;
            Worksheet = null;
            Workbook = Application.Workbooks.Open(fileconnection);
            if (Workbook != null)
            {
                Worksheet = Workbook.Worksheets.get_Item(1) as Worksheet;
                return Worksheet.UsedRange.Value;
            }
            throw new ArgumentNullException("WorkBool Is Null");
        }

        public List<TEntity> SetExcelEntities(object[,] datas, Dictionary<PropertyInfo, int> Target)
        {
            var properties = typeof(TEntity).GetProperties();
            var Keys = Target.Keys;
            int i = 2;
            List<TEntity> entities = new();
            try
            {
                while (datas[i, 2] != null)
                {
                    TEntity entity = new();
                    foreach (var key in Keys)
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
                    if (findentity == null)
                    {
                        entities.Add(entity);
                        i++;
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
                return entities;
            }
            Application.Workbooks.Close();
            Application = null;
            return entities;
        }
    }
    public class CenterFileFactory<TEntity> : EntityFileFactory<TEntity>, ICenterFileFactory<TEntity> where TEntity : Center, new()
    {
        public Dictionary<string, List<TEntity>> SetExcelCenters(object[,] datas, Dictionary<PropertyInfo, int> Target, int UserTarget)
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
                        string UserCode = datas[i, UserTarget].ToString();
                        // UserCode 라는 Key가 있는지 확인
                        bool IsContain = keyValuePairs.ContainsKey(UserCode);
                        if(IsContain)
                        {
                            var values = keyValuePairs[UserCode];
                            values.Add(entity);
                            i++;
                        }
                        else
                        {
                            keyValuePairs.Add(UserCode, new List<TEntity>() {entity});
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
    public interface IStatusFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Status
    {

    }
    public class StatusFileFactory<TEntity> : EntityFileFactory<TEntity>, IStatusFileFactory<TEntity> where TEntity : Status, new()
    {

    }
}
