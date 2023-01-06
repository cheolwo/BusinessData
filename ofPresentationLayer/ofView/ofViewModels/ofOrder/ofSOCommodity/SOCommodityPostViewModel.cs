using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofOrder.ofSOCommodity
{
    public class SOCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SOCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SOCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SOCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SOCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public SOCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SOCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus>, IObserver<TSStatus> where TSStatus : SOCommodityDTO, new()
    {
        public SOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SOCommodityGetsViewModel()
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