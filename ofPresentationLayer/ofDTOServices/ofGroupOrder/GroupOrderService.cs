using System;
using BusinessData.ofPresendationLayer.ofDTOServices;

namespace BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder
{
    public class GroupOrderServiceOptions : DTOServiceOptions
    {

    }
    public class GroupOrderService : DTOService
    {
        protected GroupOrderServiceOptions _GroupOrderServiceOptions;
        public GroupOrderService(GroupOrderServiceOptions options)
            :base(options)
        {
            _GroupOrderServiceOptions = options;
            if (_GroupOrderServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.GroupOrderWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class GOCDTOService : GroupOrderService
    {
        public GOCDTOService(GroupOrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class GOCCDTOService : GroupOrderService
    {
        public GOCCDTOService(GroupOrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class SGOCDTOService : GroupOrderService
    {
        public SGOCDTOService(GroupOrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MGOCDTOService : GroupOrderService
    {
        public MGOCDTOService(GroupOrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EGOCDTOService : GroupOrderService
    {
        public EGOCDTOService(GroupOrderServiceOptions options)
            : base(options)
        {

        }  
    }
}
