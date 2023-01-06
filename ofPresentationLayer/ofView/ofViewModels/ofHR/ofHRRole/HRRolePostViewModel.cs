using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofHR.ofHRRole
{
    public class HRRolePostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRolePostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRRolePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRRolePutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRolePutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRRolePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRRoleDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRoleDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRRoleDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRRoleGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : HRRoleDTO, new()
    {
        public HRRoleGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRRoleGetsViewModel()
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