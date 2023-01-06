using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofWarehouse
{
    public class WarehouseServiceOptions : DTOServiceOptions
    {

    }
    public class WarehouseService : DTOService
    {
        protected WarehouseServiceOptions _WarehouseServiceOptions;
        public WarehouseService(WarehouseServiceOptions options)
                :base(options)
        {
            _WarehouseServiceOptions = options;
            if (_WarehouseServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.WarehouseWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class WarehouseDTOService : WarehouseService
    {
        public WarehouseDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class WCommodityDTOService : WarehouseService
    {
        public WCommodityDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class SWCommodityDTOService : WarehouseService
    {
        public SWCommodityDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MWCommodityDTOService : WarehouseService
    {
        public MWCommodityDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EWCommodityDTOService : WarehouseService
    {
        public EWCommodityDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class IncomingTagDTOService : WarehouseService
    {
        public IncomingTagDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class DividedTagDTOService : WarehouseService
    {
        public DividedTagDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class WorkingDeskDTOService : WarehouseService
    {
        public WorkingDeskDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class LoadFrameDTOService : WarehouseService
    {
        public LoadFrameDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
    public class DotBarcodeDTOService : WarehouseService
    {
        public DotBarcodeDTOService(WarehouseServiceOptions options)
            : base(options)
        {

        }  
    }
}
