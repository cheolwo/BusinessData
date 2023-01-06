using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofViewModels.ofWebApp.ofCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessView.ofViewModels.ofWebApp.ofCommon
{
    // 단순 유저 CRUD 용 BaseUserViewModel
    public class BaseUserViewModel : BaseViewModel
    {
        protected UserActorContext _userActor;
        private IdentityUserDTO identityUserDTO = new();
        public IdentityUserDTO IdentityUserDTO
        {
            get => identityUserDTO;
            set
            {
                SetValue(ref identityUserDTO, value);
            }
        }
        public BaseUserViewModel(UserActorContext userActor)
        {
            _userActor = userActor;
        }
    }
    public class GetUserViewModel : BaseUserViewModel
    {
        protected IHttpContextAccessor _httpContextAccessor;
        public GetUserViewModel(UserActorContext userActor,
            IHttpContextAccessor httpContextAccessor) : base(userActor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task GetCurrentUserAsync(UserManager<IdentityUser> userManager)
        {
            var CurrentUser = await userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            IdentityUserDTO = ModelToDTO<IdentityUser, IdentityUserDTO>.ConvertToDTO(CurrentUser, new IdentityUserDTO());
        }
        public async Task<IdentityUser> GetCurrentIdentityUserAsync(UserManager<IdentityUser> userManager)
        {
            return await userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }
    }
    public class PostUserViewModel : BaseUserViewModel
    {
        public PostUserViewModel(UserActorContext userActor)
            : base(userActor)
        {

        }
        public async Task Create(IdentityUserDTO identityUserDTO)
        {
            await _userActor.PostAsync<IdentityUserDTO>(identityUserDTO);
        }
    }
    public class PutUserViewModel : BaseUserViewModel
    {
        public PutUserViewModel(UserActorContext userActor)
            : base(userActor)
        {

        }
        public async Task Update(IdentityUserDTO identityUserDTO)
        {
            await _userActor.PutAsync<IdentityUserDTO>(identityUserDTO);
        }
    }
    public class DeleteUserViewModel : BaseUserViewModel
    {
        public DeleteUserViewModel(UserActorContext userActor)
            : base(userActor)
        {

        }
        public async Task Delete(string id)
        {
            await _userActor.DeleteByIdAsync<IdentityUserDTO>(id);
        }
    }
    public class GetsUserViewModel : BaseUserViewModel
    {
        private List<IdentityUserDTO> identityUserDTOs = new();
        public List<IdentityUserDTO> IdentityUserDTOs
        {
            get => identityUserDTOs;
            private set
            {
                identityUserDTOs = value;
                OnPropertyChanged();
            }
        }
        public GetsUserViewModel(UserActorContext userActor,
            IHttpContextAccessor httpContextAccessor) : base(userActor)
        {
        }
        public async Task ExecuteLoadIdentityUserDTOCommand()
        {
            IsBusy = true;
            var identityUserDTOs = await _userActor.GetsAsync<IdentityUserDTO>();
            if (identityUserDTOs != null)
            {
                foreach (var identityUserDTO in identityUserDTOs)
                {
                    IdentityUserDTOs.Add(identityUserDTO);
                }
                IdentityUserDTO = IdentityUserDTOs.FirstOrDefault();
            }
            IsBusy = false;
        }
    }
}
