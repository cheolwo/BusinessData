using BusinessData.ofPresendationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresentationLayer.ofDTOServices.ofHR
{
    public class HRServiceOptions : DTOServiceOptions
    {

    }
    public class HRService : DTOService 
    {
        protected HRServiceOptions _HRServiceOptions;
        public HRService(HRServiceOptions options)
            :base(options)
        {
            _HRServiceOptions = options;
            if (_HRServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.HRWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class HRCenterDTOService : HRService
    {
        public HRCenterDTOService(HRServiceOptions options)
            : base(options)
        {

        }  
    }
    public class HREmployeeDTOService : HRService
    {
        public HREmployeeDTOService(HRServiceOptions options)
            : base(options)
        {

        }  
    }
    public class HRRoleDTOService : HRService
    {
        public HRRoleDTOService(HRServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EmployeeRoleDTOService : HRService
    {
        public EmployeeRoleDTOService(HRServiceOptions options)
            : base(options)
        {

        }  
    }
    public class HRBusinessPartDTOService : HRService
    {
        public HRBusinessPartDTOService(HRServiceOptions options)
            : base(options)
        {

        }  
    }
}
