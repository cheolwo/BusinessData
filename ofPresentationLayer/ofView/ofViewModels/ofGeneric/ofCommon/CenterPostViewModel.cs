using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofViewModels.ofGeneric.ofCommon;

namespace BusinessData.ofViewModels.ofGeneric.ofCommon
{
    public class CenterPostViewModel<TEntity> : EntityPostViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CenterPostViewModel() { }
    }
    public class CenterPutViewModel<TEntity> : EntityPutViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CenterPutViewModel() { }
    }
    public class CenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CenterDeleteViewModel() { }
    }
    public class CenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity> where TEntity : CenterDTO, new()
    {
        public CenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public CenterGetsViewModel() { }
    }
}