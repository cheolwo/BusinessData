using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofGroupOrder.ofSGOC
{
    public class SGOCPostViewModel<TSStatus> : SStatusPostViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public SGOCPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SGOCPutViewModel<TSStatus> : SStatusPutViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public SGOCPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SGOCDeleteViewModel<TSStatus> : SStatusDeleteViewModel<TSStatus>, IObservable<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public SGOCDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TSStatus> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class SGOCGetsViewModel<TSStatus> : SStatusGetsViewModel<TSStatus>, IObserver<TSStatus> where TSStatus : SGOCDTO, new()
    {
        public SGOCGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public SGOCGetsViewModel()
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

        public void OnNext(TSStatus value)
        {
            throw new NotImplementedException();
        }
    }
}