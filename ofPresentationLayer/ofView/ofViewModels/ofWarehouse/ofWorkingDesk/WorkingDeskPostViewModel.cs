using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofWorkingDesk
{
    public class WorkingDeskPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WorkingDeskPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WorkingDeskPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WorkingDeskPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WorkingDeskDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public WorkingDeskDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class WorkingDeskGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : WorkingDeskDTO, new()
    {
        public WorkingDeskGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public WorkingDeskGetsViewModel()
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