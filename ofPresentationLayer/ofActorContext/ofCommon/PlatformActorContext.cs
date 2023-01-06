using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class PlatformActorContext : UserActorContext
    {
        public PlatformActorContext(ActorServiceOption options)
            :base(options)
        {

        }
        protected override void OnServiceBuilder(ServiceBuilder serviceBuilder) 
        {
        }
        protected override void OnStrorageBuilder(StorageBuilder storageBuilder) 
        {
        }
        protected override void OnValidatorBuilder(ValidatorBuilder validatorBuilde) 
        {
        }
    }
}
