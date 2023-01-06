using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofTrade.ofTCommodity
{
    public class TCommodityPostViewModel<TEntity> : CommodityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : TCommodityDTO, new()
    {
        public TCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TCommodityPutViewModel<TEntity> : CommodityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : TCommodityDTO, new()
    {
        public TCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TCommodityDeleteViewModel<TEntity> : CommodityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : TCommodityDTO, new()
    {
        public TCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public TCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class TCommodityGetsViewModel<TEntity> : CommodityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : TCommodityDTO, new()
    {
        public TCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public TCommodityGetsViewModel()
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