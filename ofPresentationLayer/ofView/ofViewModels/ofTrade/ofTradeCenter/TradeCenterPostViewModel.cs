using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofTrade.ofTradeCenter
{
    public class TradeCenterPostViewModel<TEntity> : CenterPostViewModel<TEntity>, IObservable<TEntity> where TEntity : TradeCenterDTO, new()
    {
        public TradeCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TradeCenterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TradeCenterPutViewModel<TEntity> : CenterPutViewModel<TEntity>, IObservable<TEntity> where TEntity : TradeCenterDTO, new()
    {
        public TradeCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TradeCenterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TradeCenterDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : TradeCenterDTO, new()
    {
        public TradeCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public TradeCenterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TradeCenterGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : TradeCenterDTO, new()
    {
        public TradeCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TradeCenterGetsViewModel()
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

        public void OnNext(TEntity value)
        {
            throw new NotImplementedException();
        }
    }
}