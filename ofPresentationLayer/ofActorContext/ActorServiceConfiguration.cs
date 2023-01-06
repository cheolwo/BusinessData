using Microsoft.Extensions.DependencyInjection;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresentationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresentationLayer.ofDTOServices.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices;

namespace BusinessData.ofActorService
{
    public class ActorServiceOption
    {
        public const string ActorService = "ActorService";
        public bool IsDevelopment = true;
        public DTOServiceOptions DTOServiceOptions = new();
        public GroupOrderServiceOptions GroupOrderServiceOptions = new();
        public HRServiceOptions HRServiceOptions = new();
        public JournalServiceOptions JournalServiceOptions = new();
        public MarketServiceOptions MarketServiceOptions = new();
        public OrderServiceOptions OrderServiceOptions = new();
        public TradeServiceOptions TradeServiceOptions = new();
        public WarehouseServiceOptions WarehouseServiceOptions = new();
        public ProductServiceOptions ProductServiceOptions = new();
    }
    public static class ActorServiceConfiguration
    {
        public static IServiceCollection AddEmployerActorService(this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddPlatformActorService(this IServiceCollection services)
        {
          
            return services;
        }
        public static IServiceCollection AddEmployerLogisterService(this IServiceCollection services)
        {
            return services;
        }
    }
}
