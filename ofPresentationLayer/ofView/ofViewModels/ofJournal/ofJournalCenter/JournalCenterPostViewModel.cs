using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofJournal.ofJournalCenter
{
    public class JournalCenterPostViewModel<TCenter> : CenterPostViewModel<TCenter>, IObservable<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalCenterPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalCenterPutViewModel<TCenter> : CenterPutViewModel<TCenter>, IObservable<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalCenterPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalCenterDeleteViewModel<TCenter> : CenterDeleteViewModel<TCenter>, IObservable<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public JournalCenterDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCenter> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalCenterGetsViewModel<TCenter> : CenterGetsViewModel<TCenter>, IObserver<TCenter> where TCenter : JournalCenterDTO, new()
    {
        public JournalCenterGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalCenterGetsViewModel()
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