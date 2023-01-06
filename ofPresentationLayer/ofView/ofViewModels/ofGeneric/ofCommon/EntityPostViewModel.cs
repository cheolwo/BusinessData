using System.Reflection;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.Threading.Tasks;
using BusinessData.ofViewModels.ofWebApp.ofCommon;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using System.Collections.Generic;
using System;
using BusinessData.ofDataAccessLayer.ofCommon;

namespace BusinessData.ofViewModels.ofGeneric.ofCommon
{
    public delegate void PostPageToGets();
    public delegate void PutPageToGets();
    public delegate void DeletePageToGets();
    public delegate void GetsPageToPost();
    public delegate Task GetsPageToPut(string id);
    public delegate Task GetsPageToDelete(string id);
    public delegate void Busy();
    public class BaseEntityViewModel<TEntity> : BaseViewModel where TEntity : EntityDTO, new()
    {
        public BaseEntityViewModel(ActorContext ActorContext)
        {
            if (ActorContext == null)
            {

            }
            _ActorContext = ActorContext;
            ComponentMode = ComponentMode.Get;
            PropertiesByComponentMode = PropertyClassification.GetPropertiesByComponentMode(ComponentMode, typeof(TEntity));
            InitializedByComponentMode(ComponentMode);
        }
        public BaseEntityViewModel()
        {

        }
        public readonly ActorContext _ActorContext;
        protected TEntity _TEntity = new();
        public TEntity Entity
        {
            get => _TEntity;
            set
            {
                SetValue(ref _TEntity, value);
            }
        }
        private ComponentMode _ComponentMode = new();
        public ComponentMode ComponentMode
        {
            get => _ComponentMode;
            set
            {
                _ComponentMode = value;
                OnPropertyChanged();
            }
        }
        public IDictionary<string, string> StringProperty { get; private set; }
        public IDictionary<string, int> IntProperty { get; private set; }
        public IDictionary<string, DateTime?> DateTimeProperty { get; private set; }
        public List<PropertyInfo> PropertiesByComponentMode { get; private set; }
        public void PropertyToEntity()
        {
            bool IsSet = false;
            foreach (var prop in PropertiesByComponentMode)
            {
                if (IsSet == true) { IsSet = false; continue; }
                foreach (var key in StringProperty.Keys)
                {
                    if (key == prop.Name)
                    {
                        prop.SetValue(_TEntity, StringProperty[key]);
                        IsSet = true;
                        break;
                    }
                }
                if (IsSet == true) { IsSet = false; continue; }
                foreach (var key in IntProperty.Keys)
                {
                    if (key == prop.Name)
                    {
                        prop.SetValue(_TEntity, IntProperty[key]);
                        IsSet = true;
                        break;
                    }
                }

                if (IsSet == true) { IsSet = false; continue; }
                foreach (var key in DateTimeProperty.Keys)
                {
                    if (key == prop.Name)
                    {
                        prop.SetValue(_TEntity, DateTimeProperty[key]);
                        IsSet = true;
                        break;
                    }
                }
            }
            OnPropertyChanged();
            //StringProperty.Values.Clear();
            //IntProperty.Values.Clear();
            //DateTimeProperty.Values.Clear();
        }
        public void InitializedByComponentMode(ComponentMode componentMode)
        {
            if (StringProperty != null) { StringProperty.Clear(); }
            if (IntProperty != null) { IntProperty.Clear(); }
            if (DateTimeProperty != null) { DateTimeProperty.Clear(); }

            StringProperty = PropertyClassification.ClassifyStringProperty(ComponentMode, typeof(TEntity));
            IntProperty = PropertyClassification.ClassifyIntProperty(ComponentMode, typeof(TEntity));
            DateTimeProperty = PropertyClassification.ClassifyDateTimeProperty(ComponentMode, typeof(TEntity));
            PropertiesByComponentMode = PropertyClassification.GetPropertiesByComponentMode(ComponentMode, typeof(TEntity));
        }
        public async Task GetByIdAsync(string id)
        {
            Entity = await _ActorContext.GetByIdAsync<TEntity>(id);
        }
        public void SelectDetailMode()
        {
            ComponentMode = ComponentMode.Detail;
            InitializedByComponentMode(ComponentMode);
        }
        public void SelectGetMode()
        {
            ComponentMode = ComponentMode.Get;
            InitializedByComponentMode(ComponentMode);
        }
    }
    /*
    */
    public class EntityPostViewModel<TEntity> : BaseEntityViewModel<TEntity>, IEntityPostViewModel where TEntity : EntityDTO, new()
    {
        public PostPageToGets postPageToGets { get; set; }
        public EntityPostViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EntityPostViewModel()
        {

        }
        private bool _isPost = false;
        public bool IsPost
        {
            get => _isPost;
            set
            {
                _isPost = value;
                OnPropertyChanged();
            }
        }
        private TEntity _postTEntity = new();
        public TEntity PostTEntity
        {
            get => _postTEntity;
            set
            {
                SetValue(ref _postTEntity, value);
            }
        }
        public async Task<TEntity> PostAsync()
        {
            IsBusy = true;
            // File
            if (upload)
            {
                var PostValue = await _ActorContext.PostAsync(Entity, content);
                return PostValue ?? throw new InvalidOperationException();
            }
            else
            {
                var PostValue = await _ActorContext.PostAsync(Entity);
                return PostValue ??  throw new InvalidOperationException();
            }
        }
        public void Back()
        {
            Reset();
            postPageToGets();
            if (postPageToGets == null) { throw new ArgumentNullException("PostPageToGets Is Null"); }
        }
        public void Reset()
        {
            _isPost = false;
            _TEntity = new();
            OnPropertyChanged();
        }

        public Task<Entity> PostAsync(EntityDTO entity)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityPutViewModel<TEntity> : BaseEntityViewModel<TEntity>, IEntityPutViewModel where TEntity : EntityDTO, new()
    {
        public PutPageToGets putPageToGets { get; set; }
        public EntityPutViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EntityPutViewModel()
        {

        }
        private bool _isPut = false;
        public bool IsPut
        {
            get => _isPut;
            set
            {
                _isPut = value;
                OnPropertyChanged();
            }
        }
        private TEntity _putTEntity = new();
        public TEntity PutTEntity
        {
            get => _putTEntity;
            set
            {
                SetValue(ref _putTEntity, value);
            }
        }
        public async Task PutAsync(TEntity TEntity)
        {
            var PutValue = await _ActorContext.PutAsync<TEntity>(TEntity);
            if (PutValue != null)
            {
                _isPut = true;
                PutTEntity = PutValue;
                Back();
            }
        }
        public void Back()
        {
            Reset();
            if (putPageToGets == null) { throw new ArgumentNullException("PutPageToGets == null"); }
            putPageToGets();
        }
        public void Reset()
        {
            _isPut = false;
            _TEntity = new();
            _putTEntity = new();
            OnPropertyChanged();
        }

        public Task<Entity> PutAsync(EntityDTO entity)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityDeleteViewModel<TEntity> : BaseEntityViewModel<TEntity>, IEntityDeleteViewModel where TEntity : EntityDTO, new()
    {
        public DeletePageToGets deletePageToGets { get; set; }
        public EntityDeleteViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EntityDeleteViewModel()
        {

        }
        public async Task DeleteAsync(string id)
        {
            await _ActorContext.DeleteByIdAsync<TEntity>(id);
            Back();
        }
        public void Back()
        {
            Reset();
            if (deletePageToGets == null) { throw new ArgumentNullException("DeletePageToGets Is Null"); }
            deletePageToGets();
        }
        public void Reset()
        {
            Entity = new();
        }
    }
    public enum ViewMode { Table, Card, DashBoard }
    public class EntityGetsViewModel<TEntity> : BaseEntityViewModel<TEntity>, IEntityGetsViewModel where TEntity : EntityDTO, new()
    {
        public GetsPageToPost getsPageToPost { get; set; }
        public GetsPageToPut getsPageToPut { get; set; }
        public GetsPageToDelete getsPageToDelete { get; set; }


        public EntityGetsViewModel(ActorContext actorContext)
            : base(actorContext)
        {

        }
        public EntityGetsViewModel()
        {

        }
        private List<TEntity> _TEntitys = new();
        public List<TEntity> TEntitys
        {
            get => _TEntitys;
            set
            {
                SetValue(ref _TEntitys, value);
            }
        }
        private ViewMode _ViewMode = ViewMode.Table;
        public ViewMode ViewMode
        {
            get => _ViewMode;
            set
            {
                _ViewMode = value;
                OnPropertyChanged();
            }
        }
        private bool _IsInitialized;
        public bool IsInitialized
        {
            get => _IsInitialized;
            set
            {
                _IsInitialized = value;
                OnPropertyChanged();
            }
        }
        public async Task InitializedAsync(string userid = null)
        {
            if (IsInitialized is false)
            {
                if (userid == null)
                {
                    TEntitys.Clear();
                    await GetsAsync();
                    IsInitialized = true;
                }
                else
                {
                    await GetsAsyncByUserId(userid);
                    IsInitialized = true;
                }
            }
        }
        public async Task GetsAsync()
        {
            IEnumerable<TEntity> dtos = await _ActorContext.GetsAsync<TEntity>();
            if (dtos != null)
            {
                foreach (var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public async Task GetsAsyncByUserId(string userid)
        {
            IEnumerable<TEntity> dtos = await _ActorContext.GetsAsyncByUserId<TEntity>(userid);
            if (dtos != null)
            {
                foreach (var dto in dtos)
                {
                    _TEntitys.Add(dto);
                }
            }
            OnPropertyChanged();
        }
        public void GetsPageToPost()
        {
            if (getsPageToPost == null) { throw new ArgumentNullException("GetsPageToPost Is Null"); }
            getsPageToPost();
        }
        public async Task GetsPageToPut(string id)
        {
            if (getsPageToPut == null) { throw new ArgumentNullException("GetsPageToPut Is Null"); }
            await getsPageToPut(id);
        }
        public async Task GetsPageToDelete(string id)
        {
            if (getsPageToDelete == null) { throw new ArgumentNullException("GetsPageToDelete Is Null"); }
            await getsPageToDelete(id);
        }

        public Task<IEnumerable<EntityDTO>> GetToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}