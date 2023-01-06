using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofEPCommodity
{
    public class EPCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EPCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EPCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EPCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EPCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public EPCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EPCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus>, IObserver<TEStatus> where TEStatus : EPCommodityDTO, new()
    {
        public EPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EPCommodityGetsViewModel()
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

        public void OnNext(TEStatus value)
        {
            throw new NotImplementedException();
        }
    }
}