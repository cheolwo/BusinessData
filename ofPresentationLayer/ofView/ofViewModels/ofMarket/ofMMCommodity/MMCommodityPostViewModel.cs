using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofMarket.ofMMCommodity
{
    public class MMCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MMCommodityDTO, new()
    {
        public MMCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MMCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MMCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MMCommodityDTO, new()
    {
        public MMCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MMCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MMCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MMCommodityDTO, new()
    {
        public MMCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MMCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MMCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus>, IObserver<TMStatus> where TMStatus : MMCommodityDTO, new()
    {
        public MMCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MMCommodityGetsViewModel()
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