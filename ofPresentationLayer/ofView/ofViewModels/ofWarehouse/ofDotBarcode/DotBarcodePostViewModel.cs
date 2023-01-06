using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofDotBarcode
{
    public class DotBarcodePostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DotBarcodePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DotBarcodePutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DotBarcodePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DotBarcodeDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodeDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public DotBarcodeDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DotBarcodeGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : DotBarcodeDTO, new()
    {
        public DotBarcodeGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DotBarcodeGetsViewModel()
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