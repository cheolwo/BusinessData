using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofHR.ofDbContext;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofHumanResource.ofModel
{
    
    [Authorize(Roles ="Admin_HR, Employee_HR")]
    [Relation(typeof(HRCenter), "HR")]
    [BackUpDbContext(typeof(BackUpHRDbContext), DbConnectionString.BackUpHRDbConnection)]
    [DbContext(typeof(HRDbContext), DbConnectionString.HRDbConnection)]
    [DataContext(typeof(HRDataContext))]
    public class HRCenter : Center, IRelatedCenter, IRelatedRoles, IComparable
    {
        public string JournalCenterId {get; set;}
        [Get]public string BusinessNumber { get; set; }
        [Detail][Many]public List<HREmployee> HREmployees {get; set;}
        [Detail][Many]public List<EmployeeRole> EmployeeRoles {get; set;}
        [Detail][Many]public List<HRRole> HRRoles {get; set;}
        [Detail][Many]public List<HRBusinessPart> BusinessParts {get; set;}
        public HRCenter()
        {
            HREmployees = new();
            EmployeeRoles = new();
            HRRoles = new();
        }
        public override Center GetRelatedCenter()
        {
            return this;
        }
        
       
    }
    public static class ViewNameofHRCenter
    {
        public const string HRCenter = "HRCenter";
        public const string Employee = "Employee";
        public const string EmployeeRole = "EmployeeRole";
        public const string HRRole = "HRRole";
    }
    public class PossibleAPIInfo
    {
        public string BusinessCode {get; set;} // Controller 동격
        public bool Post {get; set;}
        public bool Put {get; set;}
        public bool Delete {get; set;}
        public bool Get {get; set;}
    }
    [BackUpDbContext(typeof(BackUpHRDbContext), DbConnectionString.BackUpHRDbConnection)]
    [DbContext(typeof(HRDbContext), DbConnectionString.HRDbConnection)]
    [DataContext(typeof(HRDataContext))]
    [Relation(typeof(HRBusinessPart), "HRE")]
    public class HRBusinessPart : Entity
    {
        public string PartName {get; set;}
        public HRCenter HRCenter {get; set;}
       
    }
    [BackUpDbContext(typeof(BackUpHRDbContext), DbConnectionString.BackUpHRDbConnection)]
    [DbContext(typeof(HRDbContext), DbConnectionString.HRDbConnection)]
    [DataContext(typeof(HRDataContext))]
    [Relation(typeof(HREmployee), "HRE")]
    public class HREmployee : Entity, IRelatedCenter, IRelatedRoles, IComparable
    {
        public DateTime InTime {get; set;}
        public DateTime OutTime {get; set;}
        public string PhoneNumber {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public HRCenter HRCenter {get; set;}
        public HREmployee()
        {
            HRCenter = new();
        }
        public Center GetRelatedCenter()
        {
            return HRCenter;
        }
       
    }
    [BackUpDbContext(typeof(BackUpHRDbContext), DbConnectionString.BackUpHRDbConnection)]
    [DbContext(typeof(HRDbContext), DbConnectionString.HRDbConnection)]
    [DataContext(typeof(HRDataContext))]
    [Relation(typeof(HRCenter), "HRR")]
    public class HRRole : Entity, IRelatedCenter, IRelatedRoles, IComparable
    {
        [Get]public string DetailName {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public HRCenter HRCenter {get; set;}
        public HRRole()
        {
            HRCenter = new();
        }
        public Center GetRelatedCenter()
        {
            return HRCenter;
        }
       
    }
    [BackUpDbContext(typeof(BackUpHRDbContext), DbConnectionString.BackUpHRDbConnection)]
    [DbContext(typeof(HRDbContext), DbConnectionString.HRDbConnection)]
    [DataContext(typeof(HRDataContext))]
    [Relation(typeof(HRCenter), "HRER")]
    public class EmployeeRole : Entity, IRelatedCenter, IRelatedRoles, IComparable
    {
        public HRRole HRRole {get; set;}
        public HRBusinessPart HRBusinessPart {get; set;}
        public HREmployee HREmployee {get; set;}
        [One(ViewNameofHRCenter.HRCenter)]public HRCenter HRCenter {get; set;}
        public EmployeeRole()
        {
            HRCenter = new();
        }
        public Center GetRelatedCenter()
        {
            return HRCenter;
        }
       
    }
    public static class IncomeType
    {
        public const int Hour = 10;
        public const int Month = 11;
        public const int Year = 12;
    }
    public static class JobType
    {
        public const int Regular = 10;
        public const int NotRegular = 11;
    }
}