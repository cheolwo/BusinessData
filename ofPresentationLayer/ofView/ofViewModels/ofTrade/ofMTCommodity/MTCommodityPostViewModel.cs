using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofTrade.ofMTCommodity
{
    public class MTCommodityPostViewModel<TEntity> : MStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : MTCommodityDTO, new()
    {
        public MTCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MTCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MTCommodityPutViewModel<TEntity> : MStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : MTCommodityDTO, new()
    {
        public MTCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MTCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MTCommodityDeleteViewModel<TEntity> : MStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : MTCommodityDTO, new()
    {
        public MTCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MTCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MTCommodityGetsViewModel<TEntity> : MStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : MTCommodityDTO, new()
    {
        public MTCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MTCommodityGetsViewModel()
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