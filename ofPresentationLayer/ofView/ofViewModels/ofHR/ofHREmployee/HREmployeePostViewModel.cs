using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofHR.ofHREmployee
{
    public class HREmployeePostViewModel<TCommodity> : EntityPostViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : HREmployeeDTO, new()
    {
        public HREmployeePostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HREmployeePostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HREmployeePutViewModel<TCommodity> : EntityPutViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : HREmployeeDTO, new()
    {
        public HREmployeePutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HREmployeePutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HREmployeeDeleteViewModel<TCommodity> : EntityDeleteViewModel<TCommodity>, IObservable<TCommodity> where TCommodity : HREmployeeDTO, new()
    {
        public HREmployeeDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HREmployeeDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TCommodity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HREmployeeGetsViewModel<TCommodity> : EntityGetsViewModel<TCommodity>, IObserver<TCommodity> where TCommodity : HREmployeeDTO, new()
    {
        public HREmployeeGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HREmployeeGetsViewModel()
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