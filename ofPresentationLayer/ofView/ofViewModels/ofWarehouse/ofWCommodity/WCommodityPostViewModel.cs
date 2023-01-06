using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofWCommodity
{
    public class WCommodityPostViewModel<TEntity> : CommodityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : WCommodityDTO, new()
    {
        public WCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WCommodityPutViewModel<TEntity> : CommodityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : WCommodityDTO, new()
    {
        public WCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WCommodityDeleteViewModel<TEntity> : CommodityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : WCommodityDTO, new()
    {
        public WCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public WCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WCommodityGetsViewModel<TEntity> : CommodityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : WCommodityDTO, new()
    {
        public WCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WCommodityGetsViewModel()
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