using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofMarket
{
    public class MarketServiceOptions : DTOServiceOptions
    {
        
    }
    public class MarketService : DTOService
    {
        protected MarketServiceOptions _MarketServiceOptions;
        public MarketService(MarketServiceOptions options)
            :base(options)
        {
            _MarketServiceOptions = options;
            if (_MarketServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.MarketWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class MarketDTOService : MarketService
    {
        public MarketDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
    public class PlatMarketDTOService : MarketService
    {
        public PlatMarketDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MCommodityDTOService : MarketService
    {
        public MCommodityDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
    public class SMCommodityDTOService : MarketService
    {
        public SMCommodityDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MMCommodityDTOService : MarketService
    {
        public MMCommodityDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EMCommodityDTOService : MarketService
    {
        public EMCommodityDTOService(MarketServiceOptions options)
            : base(options)
        {

        }  
    }
}
