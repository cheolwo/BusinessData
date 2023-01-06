using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System;

namespace BusinessData.ofViewModels.ofWebApp.ofWarehouse.ofDividedTag
{
    public class DividedTagPostViewModel<TEntity> : EntityPostViewModel<TEntity>, IObservable<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagPostViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DividedTagPostViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DividedTagPutViewModel<TEntity> : EntityPutViewModel<TEntity>, IObservable<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagPutViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DividedTagPutViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DividedTagDeleteViewModel<TEntity> : EntityDeleteViewModel<TEntity>, IObservable<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagDeleteViewModel(ActorContext actorContext)
            :base(actorContext)
        {
             
        }
        public DividedTagDeleteViewModel()
        {

        }

        public IDisposable Subscribe(IObserver<TEntity> observer)
        {
            throw new NotImplementedException();
        }
    }
    public class DividedTagGetsViewModel<TEntity> : EntityGetsViewModel<TEntity>, IObserver<TEntity> where TEntity : DividedTagDTO, new()
    {
        public DividedTagGetsViewModel(ActorContext actorContext)
            :base(actorContext)
        {

        }
        public DividedTagGetsViewModel()
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