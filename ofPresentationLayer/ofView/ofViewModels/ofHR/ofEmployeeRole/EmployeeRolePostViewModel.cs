using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofHR.ofEmployeeRole
{
    public class EmployeeRolePostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRolePostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EmployeeRolePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EmployeeRolePutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRolePutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EmployeeRolePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EmployeeRoleDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRoleDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EmployeeRoleDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class EmployeeRoleGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : EmployeeRoleDTO, new()
    {
        public EmployeeRoleGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EmployeeRoleGetsViewModel()
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