using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    public class BusinessInfo
    {
        [Key] public string b_no { get; set; } // 사업자등록번호
        [Required] public string start_dt { get; set; } // 개업일자
        [Required] public string p_nm { get; set; } // 대표자성명
        public string p_nm2 { get; set; } // 대표자성명2
        public string b_nm { get; set; } // 사업장 이름
        public string b_sector { get; set; } // 주업태명
        public string corp_no { get; set; } // 법인 등록번호
        public string b_type { get; set; } // 주종목명
        public string invoice_apply_dt { get; set; } // 세금계산서적용일자
        public string tax_type_change_dt { get; set; } // 최근과세유형전환일자
        public string utcc_yn { get; set; } // 단위과세전환폐업여부
        public string end_dt { get; set; } // 폐업일
        public string tax_type_cd { get; set; } // 과세유형메세지 (코드)
        public bool IsValidate { get; set; }
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
        public string tax_type { get; set; } // 과세유형메세지 (명칭)
        public string b_stt_cd { get; set; } // 납세자상태(코드) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
        public string b_stt { get; set; } // 납세자상태(명칭) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
    }
}
