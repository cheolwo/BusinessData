using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofMarket.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofModel
{
    public static class ViewNameofMarket
    {
        public const string PlatMarket = "HRCenter";
        public const string MCommodity = "MCommodity";
        public const string SMCommodity = "SMCommodity";
        public const string MMCommodity = "MMCommodity";
        public const string EMCommodity = "EMCommodity";
        public const string PMMCommodity = "PMMCommodity";
        public const string Market = "Market";
        public const string DetailofMCommodity = "DetailofMCommodity";
        public const string Option = "Option";
    }
    [BackUpDbContext(typeof(BackUpMarketDbContext), DbConnectionString.BackUpMarketDbConnection)]
    [DbContext(typeof(MarketDbContext), DbConnectionString.MarketDbConnection)]
    [DataContext(typeof(MarketDataContext))]
    [Relation(typeof(Market), "M")]
    [NotMapped]
    public class Market : Center, IRelatedCenter
    {
        public string NameofMarket { get; set; }
        public List<MCommodity> MCommodities {get; set;}
        public List<SMCommodity> SMCommodities {get; set; }
        public List<MMCommodity> MMCommodities {get; set;}
        public List<EMCommodity> EMCommodities {get; set;}

        public Market()    
        {
            MCommodities = new();
            SMCommodities = new();
            MMCommodities = new();
            EMCommodities = new();
        }
        public override bool Equals(object obj)
        {
            return obj is Market market &&
                   Id == market.Id &&
                   CreateTime == market.CreateTime &&

                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, market.ImageofInfos) &&
                   Name == market.Name &&
                   UserId == market.UserId;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override Center GetRelatedCenter()
        {
            return this;
        }
    }
}

