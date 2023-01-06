using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;
using System.Collections.Generic;
using BusinessData.ofPresentationLayer.ofDTOServices.ofHR;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofHR
{
    [HttpDTOService(typeof(HRCenterDTOService))]
    [DTOContext(typeof(HRDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class HRCenterDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string JournalCenterId {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string BusinessNumber { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<HREmployee>))]public string HREmployees {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EmployeeRole>))]public string EmployeeRoles {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<HRRole>))]public string HRRoles {get; set;}
    }
    [HttpDTOService(typeof(HREmployeeDTOService))]
    [DTOContext(typeof(HRDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class HREmployeeDTO : EntityDTO
    {
        [Query(QueryCode.Time)]public DateTime InTime {get; set;}
        [Query(QueryCode.Time)]public DateTime OutTime {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string PhoneNumber {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string HRCenter {get; set;}
    }
    [HttpDTOService(typeof(HRRoleDTOService))]
    [DTOContext(typeof(HRDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class HRRoleDTO : EntityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string DetailName {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter,typeof(HRCenter))]public string HRCenter {get; set;}
    }
    [HttpDTOService(typeof(HRBusinessPartDTOService))]
    [DTOContext(typeof(HRDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class HRBusinessPartDTO : EntityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string PartName {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Get)][One(typeof(HRCenter))]public string HRCenter {get; set;}
    }
    [HttpDTOService(typeof(EmployeeRoleDTOService))]
    [DTOContext(typeof(HRDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class EmployeeRoleDTO :EntityDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HRRole))]public string HRRole {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HRBusinessPart))]public string HRBusinessPart {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(HREmployee))]public string HREmployee {get; set;}
        [Query(QueryCode.With)][One(ViewNameofHRCenter.HRCenter, typeof(HRCenter))]public string HRCenter {get; set;}
    }
}