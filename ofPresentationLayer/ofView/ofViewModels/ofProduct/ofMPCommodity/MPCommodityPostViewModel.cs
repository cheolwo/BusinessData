using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofMPCommodity
{
    public class MPCommodityPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MPCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MPCommodityPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MPCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MPCommodityDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MPCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MPCommodityGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus>, IObserver<TMStatus> where TMStatus : MPCommodityDTO, new()
    {
        public MPCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MPCommodityGetsViewModel()
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