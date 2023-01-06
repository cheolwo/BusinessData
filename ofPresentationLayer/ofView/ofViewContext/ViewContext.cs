using BusinessData.ofPresentationLayer.ofDTOServices;
using BusinessData.ofViewModels.ofGeneric;
using BusinessData.ofViewModels.ofWebApp.ofCommon;
using System;
using System.Collections.Generic;

namespace BusinessView.ofViewContext
{
    // 1. ViewModel 을 구성하는 단계
    // 2. ObservingView를 구성하는 단계 (GetsViewModel 과 Post, Put, DeleteVieWModel 간 Observing 을 구성하는 단계)
    // 3. PageViewModel를 구성하는 단계
    // 4. PageViewModel 과 ViewModel의 GetsViewModel 간 Observing 을 구성하는 단계
    // 지휘계통에 따른 보고가 이루어질 수 있도록 만든다.
    // 변화는 Observable 개체로부터 발생되며 계통에 따른 보고체계가 이루어진다.
    public abstract class ViewContext
    {
        protected EntityPostViewModelBuilder entityPostViewModelBuilder = new();
        protected EntityPutViewModelBuilder entityPutViewModelBuilder = new();
        protected EntityDeleteViewModelBuilder entityDeleteViewModelBuilder = new();
        protected EntityGetsViewModelBuilder entityGetsViewModelBuilder = new();
        protected EntityPageViewModelBuilder entityPageVieWModelBuilder = new();
        public ViewContext()
        {
            OnConfigurePostViewModel(entityPostViewModelBuilder);
            OnConfigurePutViewModel(entityPutViewModelBuilder);
            OnConfigureDeleteViewModel(entityDeleteViewModelBuilder);
            OnConfigureGetsViewModel(entityGetsViewModelBuilder);
            OnConfigureObservingofViewModel(); // GetsViewModel 과 Post, Put, Delete 간 Observing 관계를 적용
            OnConfigurePageViewModel(entityPageVieWModelBuilder);
            OnConfigureObservingofPageViewModel(); // PageViewModel 과 GetsViewModel 간 Observing 관계를 적용
        }
        protected abstract void OnConfigurePostViewModel(EntityPostViewModelBuilder entityPostViewModelBuilder);
        protected abstract void OnConfigurePutViewModel(EntityPutViewModelBuilder entityPurViewModelBuidler);
        protected abstract void OnConfigureDeleteViewModel(EntityDeleteViewModelBuilder entityDeleteViewModelBuilder);
        protected abstract void OnConfigureGetsViewModel(EntityGetsViewModelBuilder entityGetsViewModelBuilder);
        protected abstract void OnConfigureObservingofViewModel();
        protected abstract void OnConfigurePageViewModel(EntityPageViewModelBuilder entityPageViewModelBuilder);
        protected abstract void OnConfigureObservingofPageViewModel();
    }
    // public class BaseBuilder<T> where T : class
    // {
    //     private Dictionary<int, T> DicT { get; set; }
    //     public BaseBuilder()
    //     {
    //         DicT = new();
    //     }
        
    //     public void Add(string nameofDTO, T t)
    //     {
    //         DicT.Add(nameofDTO.GetHashCode(), t);
    //     }

    //     public DTOService Get(string nameofDTO)
    //     {
    //         return DicT[nameofDTO.GetHashCode()]
    //                ?? throw new ArgumentNullException("Not Include Model");
    //     }
    // }
    public class EntityPostViewModelBuilder
    {
        private Dictionary<int, IEntityPostViewModel> DicEntityPostViewModel { get; set; }
        public EntityPostViewModelBuilder()
        {
            DicEntityPostViewModel = new();
        }
        
        public void Add(string nameofDTO, IEntityPostViewModel entityPostViewModel)
        {
            DicEntityPostViewModel.Add(nameofDTO.GetHashCode(), entityPostViewModel);
        }

        public IEntityPostViewModel Get(string nameofDTO)
        {
            return DicEntityPostViewModel[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewModel");
        }
    }
    public class EntityPutViewModelBuilder
    {
        private Dictionary<int, IEntityPutViewModel> DicEntityPutViewModel { get; set; }
        public EntityPutViewModelBuilder()
        {
            DicEntityPutViewModel = new();
        }
        
        public void Add(string nameofDTO, IEntityPutViewModel entityPutViewModel)
        {
            DicEntityPutViewModel.Add(nameofDTO.GetHashCode(), entityPutViewModel);
        }

        public IEntityPutViewModel Get(string nameofDTO)
        {
            return DicEntityPutViewModel[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewModel");
        }
    }
    public class EntityDeleteViewModelBuilder
    {
        private Dictionary<int, IEntityDeleteViewModel> DicEntityDeleteViewModel { get; set; }
        public EntityDeleteViewModelBuilder()
        {
            DicEntityDeleteViewModel = new();
        }
        
        public void Add(string nameofDTO, IEntityDeleteViewModel entityDeleteViewModel)
        {
            DicEntityDeleteViewModel.Add(nameofDTO.GetHashCode(), entityDeleteViewModel);
        }

        public IEntityDeleteViewModel Get(string nameofDTO)
        {
            return DicEntityDeleteViewModel[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewModel");
        }
    }
    public class EntityGetsViewModelBuilder
    {
        private Dictionary<int, IEntityGetsViewModel> DicEntityGetsViewModel { get; set; }
        public EntityGetsViewModelBuilder()
        {
            DicEntityGetsViewModel = new();
        }
        
        public void Add(string nameofDTO, IEntityGetsViewModel entityGetsViewModel)
        {
            DicEntityGetsViewModel.Add(nameofDTO.GetHashCode(), entityGetsViewModel);
        }

        public IEntityGetsViewModel Get(string nameofDTO)
        {
            return DicEntityGetsViewModel[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewModel");
        }
    }
    public class EntityPageViewModelBuilder
    {
        private Dictionary<int, IEntityPageViewModel> DicEntityPageViewModel { get; set; }
        public EntityPageViewModelBuilder()
        {
            DicEntityPageViewModel = new();
        }
        
        public void Add(string nameofDTO, IEntityPageViewModel entityPageViewModel)
        {
            DicEntityPageViewModel.Add(nameofDTO.GetHashCode(), entityPageViewModel);
        }

        public IEntityPageViewModel Get(string nameofDTO)
        {
            return DicEntityPageViewModel[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include ViewModel");
        }
    }
    
}
