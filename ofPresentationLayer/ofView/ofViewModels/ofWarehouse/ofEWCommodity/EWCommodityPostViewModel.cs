using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofEWCommodity
{
    public class EWCommodityPostViewModel<TEntity> : EStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : EWCommodityDTO, new()
    {
        public EWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EWCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EWCommodityPutViewModel<TEntity> : EStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : EWCommodityDTO, new()
    {
        public EWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EWCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EWCommodityDeleteViewModel<TEntity> : EStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : EWCommodityDTO, new()
    {
        public EWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public EWCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EWCommodityGetsViewModel<TEntity> : EStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : EWCommodityDTO, new()
    {
        public EWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public EWCommodityGetsViewModel()
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