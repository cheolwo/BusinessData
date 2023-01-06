using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusienssData.ofDataAccessLayer.ofEntityDTORepository.ofGeneric
{
    public interface IEntityDTORepository<DTO, Model> : IEntityDataRepository<Model> where DTO : EntityDTO, new() where Model : Entity, new()
    {
        Task<List<DTO>> QueryMatching(QueryCode queryCode, PropertyInfo propertyInfo, DTO dto);
    }
    /*
        분류된 Dic을 EntityDataRepository 에 전달하는 단계
        List<Model> models = await _EntityDataRepository.QueryChaining(QueryDic, dto);
    */
    public class EntityDTORepository<TDTO, TModel> : EntityDataRepository<TModel>, IEntityDTORepository<TDTO, TModel>
                                        where TDTO : EntityDTO, new() where TModel : Entity, new()
    {
        private readonly List<TModel> QueryModels = new();
        public EntityDTORepository(DbContext dbContext)
                : base(dbContext)
        {

        }
        public async Task<List<TModel>> QueryChaining(Dictionary<QueryCode, List<PropertyInfo>> queryDic, TDTO dto)
        {
            List<TModel> queryModels = new List<TModel>();
            foreach (var code in queryDic.Keys)
            {
                var props = queryDic[code];
                foreach (var prop in props)
                {
                    await QueryMatching(code, prop, dto);
                }
            }
            return queryModels;
        }

        public virtual async Task<List<TDTO>> QueryMatching(QueryCode queryCode, PropertyInfo propertyInfo, TDTO dto)
        {
            List<TDTO> tDTOs = new();
            var method = typeof(EntityDataRepository<TModel>).GetMethod(propertyInfo.Name);
            // 매칭하는데 이름이 필요하네.
            //method.Invoke(this, (string)propertyInfo.GetValue(dto));
            // method.Invoke((string)propertyInfo.GetValue(dto));
            return tDTOs;
        }
    }
}
