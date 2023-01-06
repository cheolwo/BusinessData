using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofWarehouse
{
    public class WarehousePostViewModel<TEntity> : CenterPostViewModel<TEntity>, IObservable<TEntity> where TEntity : WarehouseDTO, new()
    {
        public WarehousePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WarehousePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WarehousePutViewModel<TEntity> : CenterPutViewModel<TEntity>, IObservable<TEntity> where TEntity : WarehouseDTO, new()
    {
        public WarehousePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WarehousePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WarehouseDeleteViewModel<TEntity> : CenterDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : WarehouseDTO, new()
    {
        public WarehouseDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public WarehouseDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WarehouseGetsViewModel<TEntity> : CenterGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : WarehouseDTO, new()
    {
        public WarehouseGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WarehouseGetsViewModel()
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