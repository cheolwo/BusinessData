using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofGroupOrder.ofMGOC
{
    public class MGOCPostViewModel<TMStatus> : MStatusPostViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public MGOCPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MGOCPutViewModel<TMStatus> : MStatusPutViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public MGOCPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MGOCDeleteViewModel<TMStatus> : MStatusDeleteViewModel<TMStatus>, IObservable<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public MGOCDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TMStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class MGOCGetsViewModel<TMStatus> : MStatusGetsViewModel<TMStatus>, IObserver<TMStatus> where TMStatus : MGOCDTO, new()
    {
        public MGOCGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public MGOCGetsViewModel()
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

        public void OnNext(TMStatus value)
        {
            throw new NotImplementedException();
        }
    }
}