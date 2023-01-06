using BusinessData.ofPresentationLayer.ofDTOServices;
using System;

namespace BusinessData.ofPresendationLayer.ofDTOServices.ofProduct
{
    public class ProductServiceOptions : DTOServiceOptions
    {

    }
    public class ProductService : DTOService
    {
        protected ProductServiceOptions _ProductServiceOptions;
        public ProductService(ProductServiceOptions options)
            :base(options)
        {
            _ProductServiceOptions = options;
            if (_ProductServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.ProductWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class ProductCenterDTOService : ProductService
    {
        public ProductCenterDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class ProducterDTOService : ProductService
    {
        public ProducterDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class ProductLandDTOService : ProductService
    {
        public ProductLandDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class PCommodityDTOService : ProductService
    {
        public PCommodityDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class SPCommodityDTOService : ProductService
    {
        public SPCommodityDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class MPCommodityDTOService : ProductService
    {
        public MPCommodityDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
    public class EPCommodityDTOService : ProductService
    {
        public EPCommodityDTOService(ProductServiceOptions options)
            : base(options)
        {

        }  
    }
}
