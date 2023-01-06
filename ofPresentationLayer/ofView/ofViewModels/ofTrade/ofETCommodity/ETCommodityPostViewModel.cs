using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofTrade.ofETCommodity
{
    public class ETCommodityPostViewModel<TEntity> : EStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : ETCommodityDTO, new()
    {
        public ETCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ETCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ETCommodityPutViewModel<TEntity> : EStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : ETCommodityDTO, new()
    {
        public ETCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ETCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ETCommodityDeleteViewModel<TEntity> : EStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : ETCommodityDTO, new()
    {
        public ETCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public ETCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ETCommodityGetsViewModel<TEntity> : EStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : ETCommodityDTO, new()
    {
        public ETCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ETCommodityGetsViewModel()
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