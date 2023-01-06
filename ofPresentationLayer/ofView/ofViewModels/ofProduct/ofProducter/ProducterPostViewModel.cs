using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofProduct;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofProduct.ofProducter
{
    public class ProducterPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProducterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProducterPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProducterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProducterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public ProducterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class ProducterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : ProducterDTO, new()
    {
        public ProducterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public ProducterGetsViewModel()
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