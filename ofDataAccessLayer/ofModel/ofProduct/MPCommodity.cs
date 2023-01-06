using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofProduct.ofDbContext;
using System;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofProduct.ofModel
{
    [BackUpDbContext(typeof(BackUpProductDbContext), DbConnectionString.BackUpProductDbConnection)]
    [DbContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [DataContext(typeof(ProductDataContext))]
    [Relation(typeof(MPCommodity), "PLPM")]
    public class MPCommodity : MStatus
    {
        public PCommodity PCommodity { get; set; }
        public ProductLand ProductLand { get; set; }
        public Producter Producter { get; set; }
        public SPCommodity SPCommodity { get; set; }
        public List<EPCommodity> EPCommodities { get; set; }
        public MPCommodity()
        {
            PCommodity = new();
        }
        public override bool Equals(object obj)
        {
            return obj is MPCommodity commodity &&
                   base.Equals(obj) &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}