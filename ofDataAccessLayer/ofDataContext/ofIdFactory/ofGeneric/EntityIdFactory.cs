using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory
{
    public interface IEntityIdFactory
    {
        Task ConfigureIdAsync(Entity entity, DbContext dbConext, IEntityDataRepository entityDataRepository);
    }
    public interface IEntityIdFactory<TEntity> : IEntityIdFactory where TEntity : Entity
    {
        Task<string> CreateIdByRelationEntity(TEntity entity);
        Task<string> CreateAsync(TEntity entity);
        List<TEntity> SetEntityId(List<TEntity> entities, int count);
    }

    public class EntityIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity : Entity, new()
    {
        protected readonly IEntityDataRepository<TEntity> _entityDataRepository;
        private int ChainingCode = 0;
        protected string RelationCode { get; set; }
        public TEntity Entity = new();
        public EntityIdFactory(IEntityDataRepository<TEntity> entityDataRepository)
        {
            _entityDataRepository = entityDataRepository;
            RelationCode = Entity.GetRelationCode(typeof(TEntity));
        }
        public EntityIdFactory()
        {

        }
        // 이거 하다가 Error 발생하면 쓰레드 부분에서 발생할 가능성이 있음.
        public virtual async Task<string> CreateAsync(TEntity entity)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(RelationCode); ;
            stringBuilder.Append('-');
            int Count = await _entityDataRepository.GetCountAsync();
            stringBuilder.Append(Count);
            return stringBuilder.ToString();
        }
        public virtual async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(entity.GetRelationCode(typeof(TEntity)));
            stringBuilder.Append('-');

            string dateTime = DateTime.Now.ToString("YY//MM/dd");
            string[] strs = dateTime.Split('-');

            foreach(var str in strs)
            {
                stringBuilder.Append(str);
            }
            stringBuilder.Append('-');
            int Count = await _entityDataRepository.GetCountAsync();
            stringBuilder.Append(Count);

            // Chaining Code
            stringBuilder.Append('-');
            stringBuilder.Append(ChainingCode);

            var CurrentEntity = await _entityDataRepository.GetByIdAsync(stringBuilder.ToString());
            if(CurrentEntity != null)
            {
                ChainingCode++;
                await CreateIdByRelationEntity(entity);
            }

            return stringBuilder.ToString();
        }
        
        public List<TEntity> SetEntityId(List<TEntity> entities, int count)
        {
            int SetCount = count;
            foreach(var entity in entities)
            {
                StringBuilder stringBuilder = new();
                stringBuilder.Append(entity.GetRelationCode(typeof(TEntity)));
                stringBuilder.Append('-');
                stringBuilder.Append(SetCount);
                entity.Id = stringBuilder.ToString();
                SetCount++;
            }
            return entities;
        }

        public virtual async Task ConfigureIdAsync(Entity entity, DbContext dbContext, IEntityDataRepository entityDataRepository)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(entity.GetRelationCode(typeof(TEntity)));
            stringBuilder.Append('-');

            string dateTime = DateTime.Now.ToString("MM");
            string[] strs = dateTime.Split('-');

            foreach (var str in strs)
            {
                stringBuilder.Append(str);
            }
            stringBuilder.Append('-');
            stringBuilder.Append(entity.UserId);
            stringBuilder.Append('-');
            int Count = await entityDataRepository.GetCountAsync(dbContext);
            stringBuilder.Append(Count);
            entity.Id = stringBuilder.ToString();
        }
    }
}