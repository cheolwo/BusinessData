using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofGroupOrder.ofGOCC
{
    public class GOCCPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public GOCCPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class GOCCPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public GOCCPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class GOCCDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public GOCCDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class GOCCGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : GOCCDTO, new()
    {
        public GOCCGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public GOCCGetsViewModel()
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

        public void OnNext(TCommodity value)
        {
            throw new NotImplementedException();
        }
    }
}