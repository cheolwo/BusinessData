using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofGeneric
{
    public interface ICommodityManager<TEntity> : IEntityManager<TEntity> where TEntity : Commodity, new()
    {   
        Task<Dictionary<string, List<TEntity>>> ExcelToCommodityEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget);
    }
    public class CommodityManager<TEntity> : EntityManager<TEntity>, ICommodityManager<TEntity> 
                                                                where TEntity : Commodity, new()
    {
        private readonly ICommodityFileFactory<TEntity> _commodityFileFactory;
        private readonly ICommodityIdFactory<TEntity> _commodiyIdFactory;
        public CommodityManager(ICommodityDataRepository<TEntity> commodityDataRepository,
            ICommodityIdFactory<TEntity> commodityIdFactory,
                            ICommodityFileFactory<TEntity> commodityFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory)
            : base(commodityDataRepository, commodityIdFactory, commodityFileFactory, entityBlobStorage, dicConvertFactory)
        {
            _commodityFileFactory = commodityFileFactory;
            _commodiyIdFactory = commodityIdFactory;
        }
        // public override async Task<TEntity> CreateAsync(TEntity entity)
        // {
        //     return await base.CreateAsync(entity);
        // }
        public async Task<Dictionary<string, List<TEntity>>> ExcelToCommodityEntities(string fileconnectionString, Dictionary<PropertyInfo, int> Target,
                                            int UserCodeTarget)
        {
            int count = await _EntityDataRepository.GetCountAsync();
            var datas = _EntityFileFactory.InitExcelData(fileconnectionString);
            var CenterKeyCommodityValue = _commodityFileFactory.SetExcelCommodities(datas, Target, UserCodeTarget);
            return _commodiyIdFactory.SetCenterKeyCommodityValueId(CenterKeyCommodityValue, count);
        }
    }
}