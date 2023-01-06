using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofHR.ofHRCenter
{
    public class HRCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRCenterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRCenterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRCenterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : HRCenterDTO, new()
    {
        public HRCenterGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRCenterGetsViewModel()
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