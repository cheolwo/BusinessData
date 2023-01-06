using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory
{
    public interface IEntityContainerFactory
    {
        Task<string> ConfigureNameofContainer(Entity entity, DbContext dbContext, IEntityDataRepository entityDataRepository);
    }
    public interface IEntityContainerFactory<TEntity> : IEntityContainerFactory where TEntity : Entity
    {
        Task<string> CreateNameofContainer(TEntity entity);
        public static string Create(TEntity entity)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(entity.GetRelationCode(typeof(TEntity)));
            stringBuilder.Append('-');
            stringBuilder.Append(entity.UserId.ToLower());
            return stringBuilder.ToString();
        }
    }

    public class EntityContainerFactory<TEntity> : IEntityContainerFactory<TEntity> where TEntity : Entity, new()
    {
        private readonly IEntityDataRepository<TEntity> _entityDataRepository;
        public EntityContainerFactory(IEntityDataRepository<TEntity> entityDataRepository)
        {
            _entityDataRepository = entityDataRepository;
        }
        public EntityContainerFactory() { }
        public StringBuilder stringBuilder = new ();
        private int ChainingCode = 0;
        // 이것의 의미가 같은 형식의 같은 유저에 대한 비정형 파일은
        // 같은 공간에 저장하겠다는 의미다. 이것을 기본으로 하자.
        public virtual async Task<string> CreateNameofContainer(TEntity entity)
        {
            stringBuilder.Append(entity.GetRelationCode(typeof(TEntity))); // 1~4
            stringBuilder.Append(entity.UserId.ToLower()); // 컨테이너 이름 소문자만 가능
            stringBuilder.Append('-');
            stringBuilder.Append(ChainingCode);
            string ContainerName = stringBuilder.ToString();

            var CurrentEntity = await _entityDataRepository.GetByContainerAsync(ContainerName);
            if(CurrentEntity != null)
            {
                ChainingCode++;
                await CreateNameofContainer(entity);
            }
            return ContainerName;
        }

        public async Task<string> ConfigureNameofContainer(Entity entity, DbContext dbContext, IEntityDataRepository entityDataRepository)
        {
            stringBuilder.Append(entity.GetRelationCode(typeof(TEntity))); // 1~4
            stringBuilder.Append(entity.UserId.ToLower()); // 컨테이너 이름 소문자만 가능
            stringBuilder.Append('-');
            stringBuilder.Append(ChainingCode);
            string ContainerName = stringBuilder.ToString();

            var CurrentEntity = await entityDataRepository.GetByContainerAsync(ContainerName, dbContext);
            if (CurrentEntity != null)
            {
                ChainingCode++;
                await ConfigureNameofContainer(entity, dbContext, entityDataRepository);
            }
            ChainingCode = 0;
            return ContainerName;
        }
    }
    public static class ContainerStringDigit
    {
        public const int UserId = 4;
        public const int HashCode = 8;
    }
}