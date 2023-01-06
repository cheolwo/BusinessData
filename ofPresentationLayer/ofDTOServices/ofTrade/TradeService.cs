
using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofTrade
{
    public class TradeServiceOptions : DTOServiceOptions
    {

    }
    public class TradeService : DTOService
    {
        protected TradeServiceOptions _TradeServiceOptions;
        public TradeService(TradeServiceOptions options)
            :base(options)
        {
            _TradeServiceOptions = options;
            if (_TradeServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.TradeWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class TradeCenterDTOService : TradeService
    {
        public TradeCenterDTOService(TradeServiceOptions options)
            : base(options)
        {

        }  
    }
    public class TCommodityDTOService : TradeService
    {
        public TCommodityDTOService(TradeServiceOptions options)
            : base(options)
        {

        }  
    }
    public class STCommodityDTOService : TradeService
    {
        public STCommodityDTOService(TradeServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MTCommodityDTOService : TradeService
    {
        public MTCommodityDTOService(TradeServiceOptions options)
            : base(options)
        {

        }  
    }
    public class ETCommodityDTOService : TradeService
    {
        public ETCommodityDTOService(TradeServiceOptions options)
            : base(options)
        {

        }  
    }
}
