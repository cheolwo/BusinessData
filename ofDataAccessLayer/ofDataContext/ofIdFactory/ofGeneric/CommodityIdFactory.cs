using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory
{
    public interface ICommodityIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Commodity
    {
        Dictionary<string, List<TEntity>> SetCenterKeyCommodityValueId(Dictionary<string, List<TEntity>> keyValues, int count);
    }
    public class CommodityIdFactory<TEntity> : EntityIdFactory<TEntity>, ICommodityIdFactory<TEntity> where TEntity : Commodity, new()
    {
        public CommodityIdFactory(ICommodityDataRepository<TEntity> commodityDataRepository)
            : base(commodityDataRepository)
        {

        }
        public CommodityIdFactory() { }
        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
        public Dictionary<string, List<TEntity>> SetCenterKeyCommodityValueId(Dictionary<string, List<TEntity>> keyValues, int count)
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