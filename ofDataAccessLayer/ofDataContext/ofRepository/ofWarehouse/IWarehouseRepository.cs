using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface
{
    public interface IWarehouseRepository : ICenterDataRepository<Warehouse>
    {
        Task<Warehouse> GetRelatedData(Warehouse warehouse);
    }
    public interface IWCommodityRepository : ICommodityDataRepository<WCommodity>
    {

    }
    public interface ISWCommodityRepository : IStatusDataRepository<SWCommodity>
    {

    }
    public interface IMWCommodityRepository : IStatusDataRepository<MWCommodity>
    {

    }
    public interface IEWCommodityRepository : IStatusDataRepository<EWCommodity>
    {

    }
}
