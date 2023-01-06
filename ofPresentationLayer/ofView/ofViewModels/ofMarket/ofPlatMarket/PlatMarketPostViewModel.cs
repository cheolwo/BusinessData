using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofMarket.ofPlatMarket
{
    public class PlatMarketPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PlatMarketPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PlatMarketPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PlatMarketPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PlatMarketDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public PlatMarketDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class PlatMarketGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : PlatMarketDTO, new()
    {
        public PlatMarketGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public PlatMarketGetsViewModel()
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

        public void OnNext(TCenter value)
        {
            throw new NotImplementedException();
        }
    }
}