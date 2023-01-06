using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofPCommodity
{
    public class PCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public PCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : PCommodityDTO, new()
    {
        public PCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PCommodityGetsViewModel()
        {

        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(TCommodity value)
        {
            throw new NotImplementedException();
        }
    }
}