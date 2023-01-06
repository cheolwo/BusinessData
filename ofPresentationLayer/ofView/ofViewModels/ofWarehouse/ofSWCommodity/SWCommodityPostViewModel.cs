using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofSWCommodity
{
    public class SWCommodityPostViewModel<TEntity> : SStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : SWCommodityDTO, new()
    {
        public SWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SWCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SWCommodityPutViewModel<TEntity> : SStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : SWCommodityDTO, new()
    {
        public SWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SWCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SWCommodityDeleteViewModel<TEntity> : SStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : SWCommodityDTO, new()
    {
        public SWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public SWCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SWCommodityGetsViewModel<TEntity> : SStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : SWCommodityDTO, new()
    {
        public SWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public SWCommodityGetsViewModel()
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