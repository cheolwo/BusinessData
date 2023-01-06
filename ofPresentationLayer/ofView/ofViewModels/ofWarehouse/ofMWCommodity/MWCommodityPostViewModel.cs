using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofMWCommodity
{
    public class MWCommodityPostViewModel<TEntity> : MStatusPostViewModel<TEntity>, IObservable<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MWCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MWCommodityPutViewModel<TEntity> : MStatusPutViewModel<TEntity>, IObservable<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MWCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MWCommodityDeleteViewModel<TEntity> : MStatusDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public MWCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MWCommodityGetsViewModel<TEntity> : MStatusGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : MWCommodityDTO, new()
    {
        public MWCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public MWCommodityGetsViewModel()
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