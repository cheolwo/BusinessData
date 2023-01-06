using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofMarket.ofSMCommodity
{
    public class SMCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SMCommodityDTO, new()
    {
        public SMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SMCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SMCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SMCommodityDTO, new()
    {
        public SMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SMCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SMCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SMCommodityDTO, new()
    {
        public SMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public SMCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SMCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus>, IObserver<TSStatus> where TSStatus : SMCommodityDTO, new()
    {
        public SMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SMCommodityGetsViewModel()
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

        public void OnNext(TSStatus value)
        {
            throw new NotImplementedException();
        }
    }
}