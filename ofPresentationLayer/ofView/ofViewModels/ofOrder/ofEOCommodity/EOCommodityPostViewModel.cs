using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofOrder.ofEOCommodity
{
    public class EOCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EOCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EOCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EOCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EOCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public EOCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EOCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus>, IObserver<TEStatus> where TEStatus : EOCommodityDTO, new()
    {
        public EOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EOCommodityGetsViewModel()
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