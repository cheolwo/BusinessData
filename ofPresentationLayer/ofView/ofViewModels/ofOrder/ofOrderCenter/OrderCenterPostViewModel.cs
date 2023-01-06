using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofOrder.ofOrderCenter
{
    public class OrderCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OrderCenterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OrderCenterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public OrderCenterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class OrderCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : OrderCenterDTO, new()
    {
        public OrderCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public OrderCenterGetsViewModel()
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