using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofOrder
{
    public class OrderServiceOptions : DTOServiceOptions
    {

    }
    public class OrderService : DTOService
    {
        protected OrderServiceOptions _OrderServiceOptions;
        public OrderService(OrderServiceOptions options)
            :base(options)
        {
            _OrderServiceOptions = options;
            if (_OrderServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.OrderWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class OrderCenterDTOService : OrderService
    {
        public OrderCenterDTOService(OrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class OCommodityDTOService : OrderService
    {
        public OCommodityDTOService(OrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class SOCommodityDTOService : OrderService
    {
        public SOCommodityDTOService(OrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MOCommodityDTOService : OrderService
    {
        public MOCommodityDTOService(OrderServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EOCommodityDTOService : OrderService
    {
        public EOCommodityDTOService(OrderServiceOptions options)
            : base(options)
        {

        }  
    }
}
