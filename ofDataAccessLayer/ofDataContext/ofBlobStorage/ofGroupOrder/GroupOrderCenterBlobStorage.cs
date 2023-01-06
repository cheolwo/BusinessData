using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofGroupOrder.ofBlobStorage
{
    public interface IGOCCBlobContainerFactory : IEntityContainerFactory<GOCC>
    {

    }
    public interface ISGOCBlobContainerFactory : IEntityContainerFactory<SGOC>
    {

    }
    public interface IMGOCBlobContainerFactory : IEntityContainerFactory<MGOC>
    {

    }
    public interface IEGOCBlobContainerFactory : IEntityContainerFactory<EGOC>
    {

    }
    public interface IGOCBlobContainerFactory : IEntityContainerFactory<GOC>
    {

    }
    public class GOCBlobContainerFactory : EntityContainerFactory<GOC>, IGOCBlobContainerFactory
    {
        private readonly IGOCRepository _GOCRepository;
        public GOCBlobContainerFactory(IGOCRepository GOCRepository)
                :base(GOCRepository)
        {
            _GOCRepository = GOCRepository;
        }
        public override async Task<string> CreateNameofContainer(GOC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class GOCCBlobContainerFactory : EntityContainerFactory<GOCC>, IGOCCBlobContainerFactory
    {
        private readonly IGOCCRepository _GOCCRepository;
        public GOCCBlobContainerFactory(IGOCCRepository GOCCRepository)
                : base(GOCCRepository)
        {
            _GOCCRepository = GOCCRepository;
        }
        public override async Task<string> CreateNameofContainer(GOCC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class SGOCBlobContainerFactory : EntityContainerFactory<SGOC>, ISGOCBlobContainerFactory
    {
        private readonly ISGOCRepository _SGOCRepository;
        public SGOCBlobContainerFactory(ISGOCRepository SGOCRepository)
                : base(SGOCRepository)
        {
            _SGOCRepository = SGOCRepository;
        }
        public override async Task<string> CreateNameofContainer(SGOC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class MGOCBlobContainerFactory : EntityContainerFactory<MGOC>, IMGOCBlobContainerFactory
    {
        private readonly IMGOCRepository _MGOCRepository;
        public MGOCBlobContainerFactory(IMGOCRepository MGOCRepository)
                : base(MGOCRepository)
        {
            _MGOCRepository = MGOCRepository;
        }
        public override async Task<string> CreateNameofContainer(MGOC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class EGOCBlobContainerFactory : EntityContainerFactory<EGOC>, IEGOCBlobContainerFactory
    {
        private readonly IEGOCRepository _EGOCRepository;
        public EGOCBlobContainerFactory(IEGOCRepository EGOCRepository)
                : base(EGOCRepository)
        {
            _EGOCRepository = EGOCRepository;
        }
        public override async Task<string> CreateNameofContainer(EGOC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IGOCCBlobStorage : IEntityBlobStorage<GOCC>
    {

    }
    public interface ISGOCBlobStorage : IEntityBlobStorage<SGOC>
    {

    }
    public interface IMGOCBlobStorage : IEntityBlobStorage<MGOC>
    {

    }
    public interface IEGOCBlobStorage : IEntityBlobStorage<EGOC>
    {

    }
    public interface IGOCBlobStorage : IEntityBlobStorage<GOC>
    {

    }
    public class GOCBlobStorage : EntityBlobStorage<GOC>, IGOCBlobStorage
    {
        public GOCBlobStorage(IGOCBlobContainerFactory GOCBlobContainerFactory)
            : base(GOCBlobContainerFactory)
        {

        }
    }
    public class SGOCBlobStorage : EntityBlobStorage<SGOC>, ISGOCBlobStorage
    {
        public SGOCBlobStorage(ISGOCBlobContainerFactory SGOCBlobContainerFactory)
            : base(SGOCBlobContainerFactory)
        {

        }

    }
    public class MGOCBlobStorage : EntityBlobStorage<MGOC>, IMGOCBlobStorage
    {
        public MGOCBlobStorage(IMGOCBlobContainerFactory MGOCBlobContainerFactory)
            : base(MGOCBlobContainerFactory)
        {

        }
    }
    public class EGOCBlobStorage : EntityBlobStorage<EGOC>, IEGOCBlobStorage
    {
        public EGOCBlobStorage(IEGOCBlobContainerFactory EGOCBlobContainerFactory)
            : base(EGOCBlobContainerFactory)
        {

        }
    }
    public class GOCCBlobStorage : EntityBlobStorage<GOCC>, IGOCCBlobStorage
    {
        public GOCCBlobStorage(IGOCCBlobContainerFactory GOCCBlobContainerFactory)
            : base(GOCCBlobContainerFactory)
        {

        }
    }
}