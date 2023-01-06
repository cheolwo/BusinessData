using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofTrade.ofSTCommodity
{
    public class STCommodityPostViewModel<TEntity> : SStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : STCommodityDTO, new()
    {
        public STCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public STCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class STCommodityPutViewModel<TEntity> : SStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : STCommodityDTO, new()
    {
        public STCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public STCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class STCommodityDeleteViewModel<TEntity> : SStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : STCommodityDTO, new()
    {
        public STCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public STCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class STCommodityGetsViewModel<TEntity> : SStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : STCommodityDTO, new()
    {
        public STCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public STCommodityGetsViewModel()
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