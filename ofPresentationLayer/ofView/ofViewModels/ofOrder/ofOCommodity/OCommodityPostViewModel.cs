using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofOrder.ofOCommodity
{
    public class OCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public OCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : OCommodityDTO, new()
    {
        public OCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OCommodityGetsViewModel()
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