using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory
{
    public interface IStatusIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity: Status
    {

    }
    public class StatusIdFactory<TEntity> : EntityIdFactory<TEntity>, IStatusIdFactory<TEntity> where TEntity : Status,  new()
    {
        public StatusIdFactory(IStatusDataRepository<TEntity> statusDataRepository)
            : base(statusDataRepository)
        {

        }
        public StatusIdFactory() { }

        public override async Task ConfigureIdAsync(Entity entity, DbContext dbContext, IEntityDataRepository entityDataRepository)
        {
            await base.ConfigureIdAsync(entity, dbContext, entityDataRepository);
        }

        public override async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            return await base.CreateIdByRelationEntity(entity);
        }
    }
}