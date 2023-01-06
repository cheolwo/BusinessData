using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofGroupOrder.ofEGOC
{
    public class EGOCPostViewModel<TEStatus> : EStatusPostViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EGOCPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EGOCPutViewModel<TEStatus> : EStatusPutViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EGOCPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EGOCDeleteViewModel<TEStatus> : EStatusDeleteViewModel<TEStatus>, IObservable<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EGOCDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EGOCGetsViewModel<TEStatus> : EStatusGetsViewModel<TEStatus>, IObserver<TEStatus> where TEStatus : EGOCDTO, new()
    {
        public EGOCGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EGOCGetsViewModel()
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

        public void OnNext(TEStatus value)
        {
            throw new NotImplementedException();
        }
    }
}