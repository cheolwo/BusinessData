using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofDbContext;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofModel
{
    public abstract class KamisEntity : Entity
    {

    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisPart), nameof(KamisPart))]
    public class KamisPart : KamisEntity
    {
        public List<KamisCommodity> KamisCommodities { get; set; }
        public List<KamisKindofCommodity> KamisKindsofCommodities { get; set; }
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisCommodity), nameof(KamisCommodity))]
    public class KamisCommodity : KamisEntity
    {
        public string KamisPartId { get; set; }
        public KamisPart KamisPart { get; set; }
        public List<KamisKindofCommodity> KamisKindsofCommodity { get; set; }
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisKindofCommodity), nameof(KamisKindofCommodity))]
    public class KamisKindofCommodity : KamisEntity
    {
        public string WholesaleShippingUnit { get; set; } // 도매출하단위 5
        public string WholeSaleShippingUnizSize { get; set; } // 도매출하단위크기 6
        public string RetailShippingUnit { get; set; } // 소매출한단위 7
        public string RetailShippingUnitSize { get; set; } // 소매출하단위크기 8 
        public string EcoFriendlyAgriculturalProductShippingUnit { get; set; } // 친환경농산물 출하단위 11
        public string EcoFriendlyAgriculturalProductShippingUnitSize { get; set; } // 친환경농산물 출하단위 크기 12
        public string WholeSaleGrade { get; set; } // 도매등급 13
        public string RetailSaleGrade { get; set; } // 소매등급 14
        public string EcoFriendlyGrade { get; set; } // 친환경등급 16
        public List<KamisWholeSalePrice> KamisWholeSalePrices { get; set; }
        public List<KamisRetailPrice> KamisRetailPrices { get; set; }
        public KamisCommodity KamisCommodity { get; set; }
        public KamisPart KamisPart { get; set; }
        public string KamisPartId { get; set; }
        public string KamisCommodityId { get; set; } // 품목코드 1
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisGrade), nameof(KamisGrade))]
    public class KamisGrade : KamisEntity
    {
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisCountryAdministrationPart), nameof(KamisCountryAdministrationPart))]
    public class KamisCountryAdministrationPart : KamisEntity
    {
        public List<KamisMarket> KamisMakrets { get; set; }
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisMarket), nameof(KamisMarket))]
    public class KamisMarket : KamisEntity
    {
        public string KamisCountryAdministrationPartId { get; set; }
        public KamisCountryAdministrationPart KamisCountryAdministrationPart { get; set; }
        public List<KamisWholeSalePrice> KamisWholeSalePrices { get; set; }
        public List<KamisRetailPrice> KamisRetailPrices { get; set; }
    }

    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisRetailPrice), nameof(KamisRetailPrice))]
    public class KamisRetailPrice : KamisEntity
    {
        public string KamisMarketId { get; set; }
        public string KamisKindofCommodityId { get; set; }
        public string KamisGradeCode { get; set; }
        public string KamisClsCode { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public KamisMarket KamisMarket { get; set; }
        public KamisKindofCommodity KamisKindofCommodity { get; set; }
    }
    [DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
    [Relation(typeof(KamisWholeSalePrice), nameof(KamisWholeSalePrice))]
    public class KamisWholeSalePrice : KamisEntity
    {
        public string KamisMarketId { get; set; }
        public string KamisKindofCommodityId { get; set; }
        public string KamisGradeCode { get; set; }
        public string KamisClsCode { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public KamisMarket KamisMarket { get; set; }
        public KamisKindofCommodity KamisKindofCommodity { get; set; }
    }
    public class ProductPriceResult
    {
        public Condition[] condition { get; set; }
        public Data data { get; set; }
        public class Condition
        {
            public string p_startday { get; set; }
            public string p_endday { get; set; }
            public string p_itemcategorycode { get; set; }
            public string p_itemcode { get; set; }
            public string p_kindcode { get; set; }
            public string p_productrankcode { get; set; }
            public string p_countycode { get; set; }
            public string p_convert_kg_yn { get; set; }
            public string p_key { get; set; }
            public string p_id { get; set; }
            public string p_returntype { get; set; }
        }
        public class Data
        {
            public string error_code { get; set; }
            public object[] item { get; set; }
        }
    }
    public class ProductPrice
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countryname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class PeriodProductPriceListInfo
    {
        public string[] itemname { get; set; }
        public string[] kindname { get; set; }
        public string countyname { get; set; }
        public string[] marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class AverageKamisPriceInfo
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countyname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class BufferAverageKamisPriceInfo
    {
        public string[] itemname { get; set; }
        public string[] kindname { get; set; }
        public string countyname { get; set; }
        public string[] marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
    public class KamisPriceInfo
    {
        public string itemname { get; set; }
        public string kindname { get; set; }
        public string countyname { get; set; }
        public string marketname { get; set; }
        public string yyyy { get; set; }
        public string regday { get; set; }
        public string price { get; set; }
    }
}
