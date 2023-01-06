using BusinessData.ofPresendationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresendationLayer.ofDTOServices.ofTrade;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;
using BusinessData.ofActorService;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class EmployeeActorContext : UserActorContext
    {
        public EmployeeActorContext(ActorServiceOption options)
        :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
        }
        protected override void OnStrorageBuilder(StorageBuilder StorageBuilder) 
        {
        }
        protected override void OnValidatorBuilder(ValidatorBuilder ValidatorBuilder) 
        {
        }
    }
}
