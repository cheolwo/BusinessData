using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofExternal;
using System;
using System.Collections.Generic;

namespace BusinessData.ofPresentationLayer.ofDTO.ofCommon
{
    public class HttpDTOServiceAttribute : Attribute
    {
        private Type _t;
        public HttpDTOServiceAttribute(Type Type)
        {
            _t = Type;
        }
        public Type t
        {
            get => _t;
        }
    }
    public static class InitializedValue
    {
        public const string InitializedStringValue = "Null";
        public const int InitializedIntValue = 0;
    }
    public class FormAttribute : Attribute
    {
        public FormAttribute()
        {
            
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class QueryAttribute : Attribute
    {
        private QueryCode queryCode;
        public QueryAttribute(QueryCode code)
        {
            queryCode = code;
        }
        public QueryCode QueryCode
        {
            get => queryCode;
        }
    }
    public enum ViewMode { Get, Detail }

    [AttributeUsage(AttributeTargets.Property)]
    public class ViewAttribute : Attribute
    {
        public ViewMode _ViewMode { get; set; }
        public ViewAttribute(ViewMode viewMode)
        {
            _ViewMode = viewMode;
        }
    }
    public class EntityDTO 
    {
        [Query(QueryCode.Key)][View(ViewMode.Detail)] public string Id { get; set; } // 자동결정
        [Query(QueryCode.String)][View(ViewMode.Detail)] public string Code { get; set; } // 자동결정
        [Query(QueryCode.String)][Form][View(ViewMode.Get)] public string Name { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Detail)]public string Container {get; set;} // 자동결정
        [Query(QueryCode.Time)][View(ViewMode.Detail)]public DateTime CreateTime { get; set; } // 자동결정
        [Query(QueryCode.String)][View(ViewMode.Detail)]public string UserId {get; set;} // 이 부분은 인덱스로 만들어도 괜찮겠다.
        [View(ViewMode.Detail)] [Generic(typeof(List<ChangeUser>))]public string ChangedUsers {get; set;} // 자동결정
        [View(ViewMode.Detail)] [Generic(typeof(List<ImageofInfo>))]public string ImageofInfos {get; set;} // 자동결정
        [View(ViewMode.Detail)] [Generic(typeof(List<Doc>))]public string Docs {get; set;} // 자동결정
        public bool EqualsById(string id)
        {
            if(this.Id == Id ) { return true; }
            else { return false; }
        }
    }
    public class CenterDTO : EntityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)] public string LoginId { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)] public string Password { get; set; }
        [View(ViewMode.Get)] public int FailLogin {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)] [Origin(typeof(Juso))]public string Address {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)] public string CountryCode {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)] public string PhoneNumber {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)] public string FaxNumber {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<Commodity>))] public string Commodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<EStatus>))] public string EStatuses { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<MStatus>))] public string MStatuses { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<SStatus>))] public string SStatuses { get; set; }
        [View(ViewMode.Detail)][Generic(typeof(List<CenterCard>))] public string CenterCards { get; set; }
        [View(ViewMode.Detail)][Generic(typeof(List<CenterMacAddress>))] public string CenterMacAddresses { get; set; }
        [View(ViewMode.Detail)][Generic(typeof(List<CenterIPAddress>))]public string CenterIPAddresses { get; set; }
        [View(ViewMode.Detail)][Generic(typeof(List<CenterRole>))]public string CenterRoles {get; set;}
    }
    public class CommodityDTO : EntityDTO
    {
        [Query(QueryCode.String)]public string HsCode {get; set;}
        public string Producter { get; set; }
        public string Keywords { get; set; }
        public string Tags { get; set; }
        public string Options { get; set; }
        public string Category { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Detail)]public string Barcode {get; set;}
        [Query(QueryCode.ForeignKey)]public string CenterId {get; set;}
        [Query(QueryCode.With)][One(typeof(Center))][View(ViewMode.Get)]public string Center { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<EStatus>))][View(ViewMode.Get)]public string EStatuses { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<MStatus>))][View(ViewMode.Get)]public string MStatuses { get; set; }
        [Query(QueryCode.With)][Many(typeof(List<SStatus>))][View(ViewMode.Get)]public string SStatuses { get; set; }
    }
    public class StatusDTO : EntityDTO
    {
        [Query(QueryCode.ForeignKey)]public string CommodityId {get; set;}
        [Query(QueryCode.ForeignKey)]public string CenterId {get; set;}
        [Query(QueryCode.Int)]public int Quantity { get; set; }
        [Query(QueryCode.With)] public string Commodity { get; set; }
        [Query(QueryCode.With)] public string Center {get; set;}
    }
    public class SStatusDTO : StatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<MStatus>))]public string MStatuses { get; set; }
    }
    public class MStatusDTO : StatusDTO
    {
        [Query(QueryCode.ForeignKey)]public string SStatusId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Get)][One(typeof(SStatus))] public string SStatus { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Get)][Many(typeof(List<EStatus>))] public string EStatuses { get; set; }
    }
    public class EStatusDTO : StatusDTO
    {
        [Query(QueryCode.ForeignKey)]public string MStatusId {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Get)][One(typeof(MStatus))] public string MStatus { get; set; }
    }
}