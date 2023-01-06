using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofEMCommodity.ofEMCommodity
{
    public class EMCommodityPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EMCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EMCommodityPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EMCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EMCommodityDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public EMCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EMCommodityGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus>, IObserver<TEStatus> where TEStatus : EMCommodityDTO, new()
    {
        public EMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EMCommodityGetsViewModel()
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