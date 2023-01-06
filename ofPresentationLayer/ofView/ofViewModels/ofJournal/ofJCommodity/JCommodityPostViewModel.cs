using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofJournal.ofJCommodity
{
    public class JCommodityPostViewModel<TCommodity> : CommodityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JCommodityPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JCommodityPutViewModel<TCommodity> : CommodityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JCommodityPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JCommodityDeleteViewModel<TCommodity> : CommodityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public JCommodityDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JCommodityGetsViewModel<TCommodity> : CommodityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : JCommodityDTO, new()
    {
        public JCommodityGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JCommodityGetsViewModel()
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