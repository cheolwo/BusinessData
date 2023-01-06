using BusinessData.ofActorService;
using BusinessData.ofPresendationLayer.ofCommon.ofBuilder;

namespace BusinessData.ofPresendationLayer.ofActorContext.ofCommon
{
    public class EmployerActorContext : UserActorContext
    {
        public EmployerActorContext(ActorServiceOption options)
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
