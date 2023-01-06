using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofOrder.ofMOCommodity
{
    public class MOCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MOCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MOCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MOCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MOCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MOCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MOCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus>, IObserver<TMStatus> where TMStatus : MOCommodityDTO, new()
    {
        public MOCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MOCommodityGetsViewModel()
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

        public void OnNext(TMStatus value)
        {
            throw new NotImplementedException();
        }
    }
}