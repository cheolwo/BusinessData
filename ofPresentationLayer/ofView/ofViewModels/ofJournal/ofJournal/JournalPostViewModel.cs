using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofJournal;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofJournal.ofJournal
{
    public class JournalPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public JournalDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class JournalGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : JournalDTO, new()
    {
        public JournalGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public JournalGetsViewModel()
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

        public void OnNext(TEntity value)
        {
            throw new NotImplementedException();
        }
    }
}