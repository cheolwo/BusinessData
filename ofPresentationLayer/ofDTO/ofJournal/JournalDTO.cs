using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.ComponentModel.DataAnnotations;
using BusinessData.ofPresendationLayer.ofDTOServices.ofJournal;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofJournal
{
    [HttpDTOService(typeof(JournalCenterDTOService))]
    [DTOContext(typeof(JournalDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class JournalCenterDTO : CenterDTO
    {
        [Query(QueryCode.String)][Required] public string b_no { get; set; } // 사업자등록번호
        [Query(QueryCode.String)][Required] public string start_dt { get; set; } // 개업일자
        [Query(QueryCode.String)][Required] public string p_nm { get; set; } // 대표자성명
        [Query(QueryCode.String)]public string p_nm_phoneNumber {get; set;}
        [Query(QueryCode.String)]public string p_nm2 { get; set; } // 대표자성명2

        [Query(QueryCode.String)]public string b_nm { get; set; } // 사업장 이름
        [Query(QueryCode.String)]public string enus_bnm {get; set;} // 사업자 영문이름
        [Query(QueryCode.String)]public string HomePageAddress {get; set;} // 홈페이지주소
        [Query(QueryCode.String)]public string corp_no { get; set; } // 법인 등록번호

        [Query(QueryCode.String)]public int TaxOffice {get; set;} // 관할세무서 코드
        [Query(QueryCode.String)]public string b_sector { get; set; } // 주업태명
        [Query(QueryCode.String)]public string b_type { get; set; } // 주종목명

        [Query(QueryCode.String)]public string invoice_apply_dt { get; set; } // 세금계산서적용일자
        [Query(QueryCode.String)]public string tax_type_change_dt { get; set; } // 최근과세유형전환일자
        [Query(QueryCode.String)]public string utcc_yn { get; set; } // 단위과세전환폐업여부
        [Query(QueryCode.String)]public string end_dt { get; set; } // 폐업일
        [Query(QueryCode.String)]public string tax_type_cd { get; set; } // 과세유형메세지 (코드)
        public bool IsValidate {get; set;}
        /*
            01:부가가치세 일반과세자,
            02:부가가치세 간이과세자,
            03:부가가치세 과세특례자,
            04:부가가치세 면세사업자,
            05:수익사업을 영위하지 않는 비영리법인이거나 고유번호가 부여된 단체,국가기관 등,
            06:고유번호가 부여된 단체,
            07:부가가치세 간이과세자(세금계산서 발급사업자),
*            등록되지 않았거나 삭제된 경우: "국세청에 등록되지 않은 사업자등록번호입니다"
        */
        [Query(QueryCode.String)]public string tax_type { get; set; } // 과세유형메세지 (명칭)
        [Query(QueryCode.String)]public string b_stt_cd { get; set; } // 납세자상태(코드) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
        [Query(QueryCode.String)]public string b_stt { get; set; } // 납세자상태(명칭) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
        [Query(QueryCode.String)]public string ZipCode {get; set;} // 우편번호
        public bool IsHead {get; set;}
        [Query(QueryCode.String)]public string HeadOfficeAddress {get; set;}
        [Query(QueryCode.String)]public string HeadOfficeBunge {get; set;}
        [Query(QueryCode.String)]public string HeadOfficeNumber {get; set;}
        [Query(QueryCode.String)]public string HeadOfficeFax {get; set;}
    }
    [HttpDTOService(typeof(JournalDTOService))]
    [DTOContext(typeof(JournalDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class JournalDTO : EntityDTO
    {   
        public string Debits { get; set; }         // Json 으로 처리한다.
        public string Credits {get; set; }       // Json 으로 처리한다.
        public string AwesomeInfo {get; set;}
        public string JCommodity {get; set;}
    }
    [HttpDTOService(typeof(JCommodityDTOService))]
    [DTOContext(typeof(JournalDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class JCommodityDTO : CommodityDTO
    {
        public string OCommodityNo { get; set; }
        public string Journals { get; set; }
        public string JournalCenter { get; set; }
    }
}