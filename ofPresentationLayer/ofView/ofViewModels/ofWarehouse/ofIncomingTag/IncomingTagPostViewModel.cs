using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofIncomingTag
{
    public class IncomingTagPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public IncomingTagPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class IncomingTagPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public IncomingTagPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class IncomingTagDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public IncomingTagDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class IncomingTagGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : IncomingTagDTO, new()
    {
        public IncomingTagGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public IncomingTagGetsViewModel()
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