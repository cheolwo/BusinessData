using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofProductCenter
{
    public class ProductCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductCenterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductCenterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public ProductCenterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProductCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : ProductCenterDTO, new()
    {
        public ProductCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProductCenterGetsViewModel()
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

        public void OnNext(TCenter value)
        {
            throw new NotImplementedException();
        }
    }
}