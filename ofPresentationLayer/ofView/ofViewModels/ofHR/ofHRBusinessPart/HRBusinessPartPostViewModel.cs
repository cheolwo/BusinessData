using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofHR.ofHRBusinessPart
{
    public class HRBusinessPartPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRBusinessPartPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRBusinessPartPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRBusinessPartPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRBusinessPartDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRBusinessPartDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class HRBusinessPartGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : HRBusinessPartDTO, new()
    {
        public HRBusinessPartGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public HRBusinessPartGetsViewModel()
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