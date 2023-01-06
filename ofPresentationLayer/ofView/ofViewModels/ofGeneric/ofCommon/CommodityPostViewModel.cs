using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofViewModels.ofGeneric.ofCommon
{
    public class CommodityPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CommodityPostViewModel() { }
    }
    public class CommodityPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CommodityPutViewModel() { }
    }
    public class CommodityDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CommodityDeleteViewModel() { }
    }
    public class CommodityGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : CommodityDTO, new()
    {
        public CommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CommodityGetsViewModel() { }
    }
}