using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.Trade.ModelofDoc
{
    public class CerticificateofOrigin
    {
        public string DocumentNo {get; set;}
        public string IssueDate {get; set;}
        public Producter Producter {get; set;}
        public Checker Checker {get; set;}
        public string Commodity {get; set;}
        public string Origin {get;set;}
        public string Quantity {get; set;}
        public string BioChange {get; set;}
        public string Content {get; set;}
        public string ContentDate { get; set; }

        public string NameofCompany {get; set;}
    }

    public class Producter
    {
        public string ProducterName { get; set; }
        public string ProducterNumberofCivil { get; set; }
        public string ProducterPhoneNumber { get; set; }
        public string ProducterNumberofCompany { get; set; }
        public string ProducterAddress { get; set; }
    }

    public class Checker
    {
        public string CheckerAdress { get; set; }
        public string CheckerNameofCompany { get; set; }
        public string CheckerContactNumber { get; set; }
        public string CheckerName { get; set; }
    }

    public enum CertificationCellPosIssueDate { Row = 1, Column = 5 }
    public enum CertificationCellPosProducterName { Row = 6, Column = 9 }
    public enum CertificationCellPosProdecterRegistraionNumber { Row = 6, Column = 23}
    public enum CertificationCellPosProducterPhoneNumber { Row =7, Column = 9}
    public enum CertificationCellPosProducterCompanyRegisterationNumber { Row = 7, Column = 23}
    public enum CertificationCellPosProducterAddress { Row= 8, Column = 9}
    public enum CertificationCellPosNameofCommodity { Row = 9, Column = 5}
    public enum CertificationCellPosOriginofCommodity { Row = 10, Column = 5}
    public enum CertificationCellPosQuantity { Row = 11, Column = 5}
    public enum CertificationCellPosBioChange { Row = 12, Column = 5}
    public enum CertificationCellPosContent { Row = 15, Column = 1}
    public enum CertificationCellPosContentDate { Row = 20, Column = 1}
    public enum CertificationCellPosCheckerAddress { Row = 23, Column = 23}
    public enum CertificationCellPosCheckerCompany { Row = 24, Column = 23}
    public enum CertificationCellPosCheckerPhoneNumber { Row = 25, Column = 23}
    public enum CertificationCellPosCheckerName { Row = 26, Column = 23}
    public enum CertificationCellPosNameofCompany { Row = 29, Column = 1}
   
}
