using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofProductLand
{
    public class ProductLandPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductLandPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductLandPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductLandPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductLandDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public ProductLandDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductLandGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : ProductLandDTO, new()
    {
        public ProductLandGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductLandGetsViewModel()
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