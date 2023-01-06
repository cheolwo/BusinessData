using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using BusinessData.ofDataContext;
using BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness
{
    public class WarehouseDataContext : DataContext
    {
        public WarehouseDataContext(IServiceScopeFactory serviceScopeFactory)
            : base(serviceScopeFactory)
        {
        }

        //using(var scope = _ServiceScopeFactory.CreateScope())
        //{
        //    //// Post를 할 때마다 이런 식으로 만들기가 좀 그래가지고...
        //    //// 생성자에서 등록한 모듈들 간 구성을 결정시켜줄 필요가 있어.
        //    //// ViewContext에서 하려고 했던 것 마냥.

        //    //// Setting
        //    //var db = scope.ServiceProvider.GetRequiredService(t.GetDbContextType());
        //    //var repository = entityManagerBuilder.GetEntityDataRepository(typeof(t).Name);
        //    //repository.SetDbContext(db);
        //    //var IdFactory = entityManagerBuilder.GetEntityIdFactory(typeof(t).Name);
        //    //IdFactory.SetRepository(repository);
        //    //var blobContanerFactory = entityManagerBuilder.GetBlobContainerFactory(typeof(t).Name);
        //    //blobContanerFactory.SetRepository(repository);
        //    //var blobStorage = entityManagerBuilder.GetEntityBlobStorage(typeof(t).Name);
        //    //blobStorage.SetBlobContainerFactory(blobContanerFactory);

        //    //// Chain of Reponsibilty
        //    //var Result = await t.CreateIdAsync(IdFactory).CreateBlobStorageAsync(blobStorage).PostToDbContextAsync(repository);                
        //    //// InMemory 에 저장하는 단계
        //    //Result.PostToInMemory(_MemoryCache);
        //    //// 분산캐싱에 저장하는 단계    
        //    //Result.PostToDistributedMemory(_MemoryCache);          
        //}
        protected override void OnEntityBlobStorageBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityExcelBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityIdBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityIdFactory(nameof(Warehouse), new WarehouseIdFactory());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(WCommodity), new EntityIdFactory<WCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(SWCommodity), new EntityIdFactory<SWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(MWCommodity), new EntityIdFactory<MWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(EWCommodity), new EntityIdFactory<EWCommodity>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(DividedTag), new EntityIdFactory<DividedTag>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(IncomingTag), new EntityIdFactory<IncomingTag>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(LoadFrame), new EntityIdFactory<LoadFrame>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(WorkingDesk), new EntityIdFactory<WorkingDesk>());
            entityManagerBuilder.ApplyEntityIdFactory(nameof(DotBarcode), new EntityIdFactory<DotBarcode>());
        }

        protected override void OnEntityPDFBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            throw new NotImplementedException();
        }

        protected override void OnEntityRepositoryBuilder(EntityManagerBuilder entityManagerBuilder)
        {
            entityManagerBuilder.ApplyEntityDataRepository(nameof(Warehouse), new WarehouseRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(WCommodity), new WCommodityRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(SWCommodity), new SWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(MWCommodity), new MWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(EWCommodity), new EWCommodityRepository(e =>
            {
                e.UsingDistributedCache = true;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(LoadFrame), new LoadFrameRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(DividedTag), new DividedTagRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(IncomingTag), new IncomingTagRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(DotBarcode), new DotBarcodeRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
            entityManagerBuilder.ApplyEntityDataRepository(nameof(WorkingDesk), new WorkingDeskRepository(e =>
            {
                e.UsingDistributedCache = false;
                e.UsingMemoryCache = true;
                e.UsedSingleton = true;
            }));
        }
    }
}
