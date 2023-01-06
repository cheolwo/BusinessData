using System.ComponentModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofViewModels.ofWebApp.ofCommon;
using BusinessData.ofViewModels.ofGeneric.ofCommon;
using System.Threading.Tasks;

namespace BusinessData.ofViewModels.ofGeneric
{
    public interface IPropManager
    {
        // List<PropertyInfo> OnlyGetProperties();
        // List<PropertyInfo> OnlyDetailProperties();
        // List<PropertyInfo> GetOneProperties();
        // List<PropertyInfo> GetManyProperties();
        // List<PropertyInfo> DetailOneProperties();
        // List<PropertyInfo> DetailManyProperties();
    }
    //public static class EntityPropManager<TEntity> where TEntity : EntityDTO
    //{   
    //    public static IEnumerable<string> GetStringProperties(ViewMode viewmode)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public static IEnumerable<string> GetIntProperties(ViewMode viewmode)
    //    {
    //        throw new NotImplementedException();
    //    }
    //    public static IEnumerable<string> GetDateTimeProperties(ViewMode viewmode)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public interface IEntityPageViewModel
    {

    }
    public class EntityPageViewModel<TEntity> : BaseViewModel, IEntityPageViewModel where TEntity : EntityDTO, new()
    {
        public EntityPostViewModel<TEntity> _EntityPostViewModel;
        public EntityPutViewModel<TEntity> _EntityPutViewModel;
        public EntityDeleteViewModel<TEntity> _EntityDeleteViewModel;
        public EntityGetsViewModel<TEntity> _EntityGetsViewModel;
        public EntityPageViewModel(EntityPostViewModel<TEntity> EntityPostViewModel, EntityPutViewModel<TEntity> EntityPutViewModel,
                                            EntityDeleteViewModel<TEntity> EntityDeleteViewModel, EntityGetsViewModel<TEntity> EntityGetViewModel)
        {
            _EntityPostViewModel = EntityPostViewModel;
            _EntityPutViewModel =  EntityPutViewModel;
            _EntityDeleteViewModel = EntityDeleteViewModel;
            _EntityGetsViewModel = EntityGetViewModel;
        }
        public virtual void OnInitialized(PropertyChangedEventHandler propertyChangedEventHandler)
        {
               PropertyChanged += propertyChangedEventHandler;
             _EntityDeleteViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityPostViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityPutViewModel.PropertyChanged += propertyChangedEventHandler;
             _EntityGetsViewModel.PropertyChanged += propertyChangedEventHandler;

            _EntityPostViewModel.postPageToGets = OnClickPostToGets;
            _EntityPutViewModel.putPageToGets = OnClickPutToGets;
            _EntityDeleteViewModel.deletePageToGets = OnClickDeleteToGets;
            _EntityGetsViewModel.getsPageToPost = OnClickGetsToPost;
            _EntityGetsViewModel.getsPageToPut = OnClickGetsToPut;
            _EntityGetsViewModel.getsPageToDelete = OnClickGetsToDelete;

            isSelectGets = true;
            isSelectPost = false;
            isSelectPut = false;
            isSelectDelete = false;
            OnPropertyChanged();
        }
        private bool isSelectPost {get; set;}
        public bool IsSelectPost
        {
            get => isSelectPost;
            set
            {
                isSelectPost = value;
                OnPropertyChanged();
            }
            
        }
        private bool isSelectPut {get; set;}
        public bool IsSelectPut
        {
            get => isSelectPut;
            set
            {
                isSelectPut = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectDelete {get; set;}
        public bool IsSelectDelete
        {
            get => isSelectDelete;
            set
            {
                isSelectDelete = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectGets {get; set;}
        public bool IsSelectGets
        {
            get => isSelectGets;
            set
            {
                isSelectGets = value;
                OnPropertyChanged();
            }
        }
        private bool isSelectDetail { get; set; }
        public bool IsSelectDatail
        {
            get => isSelectDetail;
            set
            {
                isSelectDetail = value;
                OnPropertyChanged();
            }
        }
        public async Task OnClickGetsToDetail(string id)
        {
            isSelectGets = false;
            isSelectDetail = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public void OnClickGetsToPost()
        {
            isSelectGets = false;
            isSelectPost = true;
            OnPropertyChanged();
        }
        public async Task OnClickGetsToPut(string id)
        {
            isSelectGets = false;
            isSelectPut = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public async Task OnClickGetsToDelete(string id)
        {
            isSelectGets = false;
            isSelectDelete = true;
            await _EntityPostViewModel.GetByIdAsync(id);
        }
        public void OnClickPostToGets()
        {
            isSelectGets = true;
            isSelectPost = false;
            OnPropertyChanged();
        }
        public void OnClickPutToGets()
        {
            isSelectGets = true;
            isSelectPut = false;
            OnPropertyChanged();
        }
        public void OnClickDeleteToGets()
        {
            isSelectGets = true;
            isSelectDelete = false;
            OnPropertyChanged();
        }
    }
    public class CenterPageViewModel<TCenter> : EntityPageViewModel<TCenter> where TCenter : CenterDTO, new()
    {
        public readonly ofCommon.CenterPostViewModel<TCenter> _CenterPostViewModel;
        public readonly CenterPutViewModel<TCenter> _CenterPutViewModel;
        public readonly CenterDeleteViewModel<TCenter> _CenterDeleteViewModel;
        public readonly CenterGetsViewModel<TCenter> _CenterGetViewMode;
        public CenterPageViewModel(
            ofCommon.CenterPostViewModel<TCenter> CenterPostViewModel, 
            CenterPutViewModel<TCenter> CenterPutViewModel,
            CenterDeleteViewModel<TCenter> CenterDeleteViewModel, 
            CenterGetsViewModel<TCenter> CenterGetViewModel)
                                            :base(CenterPostViewModel, CenterPutViewModel, CenterDeleteViewModel, CenterGetViewModel)
        {
         
            _CenterPostViewModel = CenterPostViewModel;
            _CenterDeleteViewModel = CenterDeleteViewModel;
            _CenterGetViewMode = CenterGetViewModel;
            _CenterPutViewModel = CenterPutViewModel;
        }
    }
    public class CommodityPageViewModel<TCommodity> : EntityPageViewModel<TCommodity> where TCommodity : CommodityDTO, new()
    {
        public readonly CommodityPostViewModel<TCommodity> _CommodityPostViewModel;
        public readonly CommodityPutViewModel<TCommodity> _CommodityPutViewModel;
        public readonly CommodityDeleteViewModel<TCommodity> _CommodityDeleteViewModel;
        public readonly CommodityGetsViewModel<TCommodity> _CommodityGetViewMode;
        public CommodityPageViewModel(
            CommodityPostViewModel<TCommodity> CommodityPostViewModel, 
            CommodityPutViewModel<TCommodity> CommodityPutViewModel,
            CommodityDeleteViewModel<TCommodity> CommodityDeleteViewModel, 
            CommodityGetsViewModel<TCommodity> CommodityGetViewModel)
                                            :base(CommodityPostViewModel, CommodityPutViewModel, CommodityDeleteViewModel, CommodityGetViewModel)
        {
            _CommodityPostViewModel = CommodityPostViewModel;
            _CommodityDeleteViewModel = CommodityDeleteViewModel;
            _CommodityGetViewMode = CommodityGetViewModel;
            _CommodityPutViewModel = CommodityPutViewModel;
        }
    }
    public class StatusPageViewModel<TStatus> : EntityPageViewModel<TStatus> where TStatus : StatusDTO, new()
    {
        public readonly StatusPostViewModel<TStatus> _StatusPostViewModel;
        public readonly StatusPutViewModel<TStatus> _StatusPutViewModel;
        public readonly StatusDeleteViewModel<TStatus> _StatusDeleteViewModel;
        public readonly StatusGetsViewModel<TStatus> _StatusGetViewMode;
        public StatusPageViewModel(
            StatusPostViewModel<TStatus> StatusPostViewModel, 
            StatusPutViewModel<TStatus> StatusPutViewModel,
            StatusDeleteViewModel<TStatus> StatusDeleteViewModel, 
            StatusGetsViewModel<TStatus> StatusGetViewModel)
                                            :base(StatusPostViewModel, StatusPutViewModel, StatusDeleteViewModel, StatusGetViewModel)
        {
            _StatusPostViewModel = StatusPostViewModel;
            _StatusDeleteViewModel = StatusDeleteViewModel;
            _StatusGetViewMode = StatusGetViewModel;
            _StatusPutViewModel = StatusPutViewModel;
        }
    }
    public class SStatusPageViewModel<TSStatus> : StatusPageViewModel<TSStatus> where TSStatus : SStatusDTO , new()
    {
        public readonly SStatusPostViewModel<TSStatus> _SStatusPostViewModel;
        public readonly SStatusPutViewModel<TSStatus> _SStatusPutViewModel;
        public readonly SStatusDeleteViewModel<TSStatus> _SStatusDeleteViewModel;
        public readonly SStatusGetsViewModel<TSStatus> _SStatusGetViewMode;
        public SStatusPageViewModel(
            SStatusPostViewModel<TSStatus> SStatusPostViewModel, 
            SStatusPutViewModel<TSStatus> SStatusPutViewModel,
            SStatusDeleteViewModel<TSStatus> SStatusDeleteViewModel, 
            SStatusGetsViewModel<TSStatus> SStatusGetViewModel)
                                            :base(SStatusPostViewModel, SStatusPutViewModel, SStatusDeleteViewModel, SStatusGetViewModel)
        {
            _SStatusPostViewModel = SStatusPostViewModel;
            _SStatusDeleteViewModel = SStatusDeleteViewModel;
            _SStatusGetViewMode = SStatusGetViewModel;
            _SStatusPutViewModel = SStatusPutViewModel;
        }
    }
    public class MStatusPageViewModel<TMStatus> : StatusPageViewModel<TMStatus> where TMStatus : MStatusDTO , new()
    {
        public readonly MStatusPostViewModel<TMStatus> _MStatusPostViewModel;
        public readonly MStatusPutViewModel<TMStatus> _MStatusPutViewModel;
        public readonly MStatusDeleteViewModel<TMStatus> _MStatusDeleteViewModel;
        public readonly MStatusGetsViewModel<TMStatus> _MStatusGetViewMode;
        public MStatusPageViewModel(
            MStatusPostViewModel<TMStatus> MStatusPostViewModel, 
            MStatusPutViewModel<TMStatus> MStatusPutViewModel,
            MStatusDeleteViewModel<TMStatus> MStatusDeleteViewModel, 
            MStatusGetsViewModel<TMStatus> MStatusGetViewModel)
                                            :base(MStatusPostViewModel, MStatusPutViewModel, MStatusDeleteViewModel, MStatusGetViewModel)
        {
            _MStatusPostViewModel = MStatusPostViewModel;
            _MStatusDeleteViewModel = MStatusDeleteViewModel;
            _MStatusGetViewMode = MStatusGetViewModel;
            _MStatusPutViewModel = MStatusPutViewModel;
        }
    }
    public class EStatusPageViewModel<TEStatus> : StatusPageViewModel<TEStatus> where TEStatus : EStatusDTO , new()
    {
        public readonly EStatusPostViewModel<TEStatus> _EStatusPostViewModel;
        public readonly EStatusPutViewModel<TEStatus> _EStatusPutViewModel;
        public readonly EStatusDeleteViewModel<TEStatus> _EStatusDeleteViewModel;
        public readonly EStatusGetsViewModel<TEStatus> _EStatusGetViewMode;
        public EStatusPageViewModel(
            EStatusPostViewModel<TEStatus> EStatusPostViewModel, 
            EStatusPutViewModel<TEStatus> EStatusPutViewModel,
            EStatusDeleteViewModel<TEStatus> EStatusDeleteViewModel, 
            EStatusGetsViewModel<TEStatus> EStatusGetViewModel)
                                            :base(EStatusPostViewModel, EStatusPutViewModel, EStatusDeleteViewModel, EStatusGetViewModel)
        {
            _EStatusPostViewModel = EStatusPostViewModel;
            _EStatusDeleteViewModel = EStatusDeleteViewModel;
            _EStatusGetViewMode = EStatusGetViewModel;
            _EStatusPutViewModel = EStatusPutViewModel;
        }
    }
}