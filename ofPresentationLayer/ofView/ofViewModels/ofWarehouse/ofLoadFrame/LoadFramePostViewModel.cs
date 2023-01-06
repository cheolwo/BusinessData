using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofLoadFrame
{
    public class LoadFramePostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFramePostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public LoadFramePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class LoadFramePutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFramePutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public LoadFramePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class LoadFrameDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFrameDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public LoadFrameDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class LoadFrameGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : LoadFrameDTO, new()
    {
        public LoadFrameGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public LoadFrameGetsViewModel()
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