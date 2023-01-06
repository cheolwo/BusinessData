using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.Trade.ModelofDoc
{
    public class BillofLading
    {
        public string DocumentNo { get; set; }
        public string ShipperExporter { get; set; }   // 송하인
        public string ExportReferences { get; set; } // 송하인 별도 정보
        public string Consignee { get; set; }  // 특정회사의 명칭 혹은 특정인
        public string NotifyParty { get; set; } // 실제 물건이 도착했을 때 통지받을 사람
        public string ReCarriageBy { get; set; } // 다시 이동된다 누군가에게
        public string PlaceofReceipt { get; set; } // 화물수취장소
        public string OceanVesselAndVoyage { get; set; } // 선박명
        public string PortofLoading { get; set; } // 선적항
        public string PortofDischarge { get; set; } // 목적항구, 양륙항, 양허항
        public string PlaceofDelivery { get; set; } // 인도장소, 일반적으로 목적항구

        public string ForwardingAgentReferences { get; set; } // 
        public string PointAndCountryofOrigin { get; set; } // 
        public string DomesticRoutingExportInstructions { get; set; }
        public string OnWardInLandRouting { get; set; }
        public string ForTransshipmentTo { get; set; } // 최종도착지
        public string FinalDestinationForTheMerchantsReferenceOnly { get; set; }
        public string DateAt { get; set; }
        public string SignBy { get; set; }

        public List<Freight> Freights { get; set; }
        public List<ParticularsFurnishedByShipper> ParticularsFurnishedByShippers { get; set; }
    }

    public class ParticularsFurnishedByShipper
    {
        public string MarksAndNumbers { get; set; }
        public string NoofContOrOtherPkgs { get; set; }
        public string DescriptionofPackagesAndGoods { get; set; }
        public string GroosWeight { get; set; }
        public string Mesurement { get; set; }
    }

    public class Freight
    {
        public string FreightAndChares { get; set; }
        public string PrePaid { get; set; }
        public string Collect { get; set; }
    }

    public enum BillofLadingCellPosShipperExporter { Row = 5, Column = 1 }
    public enum BillofLadingCellPosDocumentNo { Row = 4, Column = 23 }
    public enum BillofLadingCellPosConsignee { Row = 8, Column = 1 }
    public enum BillofLadingCellPosNotifyParty { Row = 11, Column = 1 }
    public enum BillofLadingCellPosExportReferences { Row = 6, Column = 17 }
    public enum BillofLadingCellPosForwardingAgentReferences { Row = 8, Column = 17 }
    public enum BillofLadingCellPosPointAndCountryofOrigin { Row = 10, Column = 17 }
    public enum BillofLadingCellPosDomesticRoutingExportInstructions { Row = 12, Column = 17 }
    public enum BillofLadingCellPosOnWardInLandRouting { Row = 14, Column = 17 }
    public enum BillofLadingCellPosForTransshipmentTo { Row = 16, Column = 17 }

    public enum BillofLadingCellPosFinalDestinationForTheMerchantsReferenceOnly { Row = 18, Column = 24 }

    public enum BillofLadingCellPosReCarriageBy { Row = 14, Column = 1 }
    public enum BillofLadingCellPosPlaceofReceipt { Row = 14, Column = 9 }

    public enum BillofLadingCellPosOceanVesselAndVoyage { Row = 16, Column = 1 }
    public enum BillofLadingCellPosPortofLoading { Row = 16, Column = 9 }
    public enum BillofLadingCellPosPortofDischarge { Row = 18, Column = 1 }
    public enum BillofLadingCellPosPlaceofDelivery { Row = 18, Column = 9 }

    public enum BillofLadingCellPosMarksAndNumbers { Row = 22, Column = 1 }
    public enum BillofLadingCellPosNoofContOrOtherPkgs { Row = 22, Column = 6 }
    public enum BillofLadingCellPosDescriptionofPackagesAndGoods { Row = 22, Column = 12 }
    public enum BillofLadingCellPosGroosWeight { Row = 22, Column = 22 }
    public enum BillofLadingCellPosMeasurement { Row = 22, Column = 27 }

    public enum BillofLadingCellPosFreightAndChares { Row = 28, Column = 1 }
    public enum BillofLadingCellPosPrePaid { Row = 28, Column = 7 }
    public enum BillofLadingCellPosCollect { Row = 28, Column = 11 }

    public enum BillofLadingCellPosDateAt { Row = 35, Column = 22 }
    public enum BillofLadingCellPosSignBy { Row = 37, Column = 11 }
}

