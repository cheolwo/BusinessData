using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofSPCommodity
{
    public class SPCommodityPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SPCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SPCommodityPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SPCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SPCommodityDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public SPCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SPCommodityGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus>, IObserver<TSStatus> where TSStatus : SPCommodityDTO, new()
    {
        public SPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SPCommodityGetsViewModel()
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