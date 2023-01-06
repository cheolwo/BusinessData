using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory
{
    public interface ICenterIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Center, new()
    {
        Dictionary<string, List<TEntity>> SetUserKeyCenterValueId(Dictionary<string, List<TEntity>> keyValues, int count);
    }
    public class CenterIdFactory<TEntity> : EntityIdFactory<TEntity>, ICenterIdFactory<TEntity> where TEntity : Center, new()
    {
        public CenterIdFactory(ICenterDataRepository<TEntity> entityDataRepository)
            : base(entityDataRepository)
        {
        }
        public CenterIdFactory() { }
        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
        public Dictionary<string, List<TEntity>> SetUserKeyCenterValueId(Dictionary<string, List<TEntity>> keyValues, int count)
        {
            int Count = count;
            var Keys = keyValues.Keys;
            foreach (var key in Keys)
            {
                foreach (var value in keyValues[key])
                {
                    StringBuilder stringBuilder = new();
                    stringBuilder.Append(RelationCode);
                    stringBuilder.Append('-');
                    stringBuilder.Append(Count);
                    value.Id = stringBuilder.ToString();
                    Count++;
                }
            }
            return keyValues;
        }
    }
}