using System.Reflection;
using System;
using System.Collections.Generic;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;

namespace BusinessData.ofPresentationLayer.ofCommon
{
    public enum QueryCode { Key, ForeignKey, With, Time, String, Bool, Int }
    // 그냥 매핑하는 게 더 좋아보이기는 한다.
    public class EntityQuery<DTO> where DTO : EntityDTO, new()
    {
        public DTO Dto = new();
        [Query(QueryCode.Time)]public DateTime StartDate {get; set;}
        [Query(QueryCode.Time)]public DateTime EndDate {get; set;}
        public Dictionary<QueryCode, List<PropertyInfo>> GetQueryDictionary(EntityQuery<DTO> query)
        {
            return query.GetByQueryAttribute().DistributedByQueryCode();
        }
    }
    public class CenterQuery<DTO> : EntityQuery<DTO> where DTO : CenterDTO, new()
    {
        public bool Related {get; set;}
    }
    public class CommodityQuery<DTO> : EntityQuery<DTO> where DTO : CommodityDTO, new()
    {
    }
    public class StatusQuery<DTO> : EntityQuery<DTO>  where DTO : StatusDTO, new()
    {
    }
}