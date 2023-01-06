using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofMarket.ofMCommodity
{
    public class MCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : MCommodityDTO, new()
    {
        public MCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MCommodityGetsViewModel()
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