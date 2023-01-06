using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofMarket;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofMarket.ofMarket
{
    public class MarketPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MarketPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MarketPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MarketPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MarketDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MarketDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MarketGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : MarketDTO, new()
    {
        public MarketGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MarketGetsViewModel()
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