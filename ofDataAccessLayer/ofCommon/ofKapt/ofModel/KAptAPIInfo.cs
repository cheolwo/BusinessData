using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofKApt.ofDbContext;

namespace BusinessData.ofCommon.ofKapt
{
    [DataContext(typeof(KAptDbContext), DbConnectionString.KAptDbConnection)]
	[Relation(typeof(KAptBasicInfo), nameof(KAptBasicInfo))]
    public class KAptBasicInfo : Entity
    {
        public string County { get; set; } //1
        public string City { get; set; } //2
        public string Town { get; set; } //3
        public string Viliage { get; set; } //4
        public string Classification { get; set; } //7
        public string StreetAddress { get; set; }// 9
        public string RegalAddress { get; set; } // 8
        public string SalesType { get; set; } // 10
        public string DateofApprovalForUse { get; set; } // 11
        public string NumberofApt { get; set; } //12
        public string NumberofHouseHolds { get; set; } // 13
        public string Managementmethod { get; set; } //14
        public string Housemanager { get; set; } //19
        public string Managementmanagementmethod { get; set; } //20
        public string Generalmanagementpersonnel { get; set; } //21
        public string GuardManagement  { get; set; } // 22
        public string GuardNumber { get; set; } // 23
        public string GuardManager { get; set; } // 24
        public string Numberofparkingspaces { get; set; } //45
        public string Numberofundergroundparkingspaces { get; set; } //46
        public string ManagementOfficeAddress { get; set; } //49
        public string ManagementOfficePhoneNumber { get; set; } // 50
        public string ManagementOfficeFax { get; set; } // 51
        public string WelfareFacility { get; set; } // 52
    }
}
