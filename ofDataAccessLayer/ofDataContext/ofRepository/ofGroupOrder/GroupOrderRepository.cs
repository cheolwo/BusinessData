using System;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofDbContext;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;

namespace BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository
{
    public interface IGOCRepository : ICenterDataRepository<GOC>
    {
        Task<GOC> GetRelatedData(GOC GOC);
    }
    public interface IGOCCRepository : ICommodityDataRepository<GOCC>
    {

    }
    public interface ISGOCRepository : IStatusDataRepository<SGOC>
    {

    }
    public interface IMGOCRepository : IStatusDataRepository<MGOC>
    {

    }
    public interface IEGOCRepository : IStatusDataRepository<EGOC>
    {

    }
    public class GOCRepository : CenterDataRepository<GOC>, IGOCRepository
    {
        public GOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
        public GOCRepository(Action<RepositoryOptions> options)
            :base(options)
        {

        }
        public Task<GOC> GetRelatedData(GOC GOC)
        {
            throw new NotImplementedException();
        }
        
    }
    public class GOCCRepository : CommodityDataRepository<GOCC>, IGOCCRepository
    {
        public GOCCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
        public GOCCRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
    public class SGOCRepository : StatusDataRepository<SGOC>, ISGOCRepository
    {
        public SGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
        public SGOCRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
    public class MGOCRepository : StatusDataRepository<MGOC>, IMGOCRepository
    {
        public MGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
        public MGOCRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
    public class EGOCRepository : StatusDataRepository<EGOC>, IEGOCRepository
    {
        public EGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
        public EGOCRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
}
