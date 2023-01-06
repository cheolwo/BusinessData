using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BusinessData.ofDataAccessLayer.ofJournal.Model
{
    [BackUpDbContext(typeof(BackUpJournalDbContext), DbConnectionString.BackUpJournalDbConnection)]
    [DbContext(typeof(JournalDbContext), DbConnectionString.JournalDbConnection)]
    [DataContext(typeof(JournalDataContext))]
    public class UserSettingJournal : Entity
    {
        public string EntityTypeName {get; set;}
        public List<Debit> Debits { get; set; }         // Json 으로 처리한다.
        public List<Credit> Credits {get; set; }       // Json 으로 처리한다.
        public string AwesomeInfo {get; set; }  
        public UserSettingJournal()
        {
            Debits = new();
            Credits = new();
        }
    }
    public class JournalCenterOption
    {
        public string Slipcode {get; set;}
    }
    public class FinancialInfo : Entity
    {
        public bool IsIn {get; set;}
        public string BankNumber {get; set;}
        public string BankCode {get; set;}
        public string AccountHolder {get; set;} //예금주
        public string AccountName {get; set;}
        public Vendor vendor {get; set;}
    }
    public class Vendor : Entity
    {
        [Required] public string b_no { get; set; } // 사업자등록번호
        [Required] public string start_dt { get; set; } // 개업일자
        [Required] public string p_nm { get; set; } // 대표자성명
        public string p_nm_phoneNumber {get; set;}
        public string b_nm { get; set; } // 사업장 이름
        public string enus_bnm {get; set;} // 사업자 영문이름
        public string HomePageAddress {get; set;} // 홈페이지주소
        public string corp_no { get; set; } // 법인 등록번호
        public string b_sector { get; set; } // 주업태명
        public string b_type { get; set; } // 주종목명
        public bool IsHead {get; set;}
        public string ZipCode {get; set;} // 우편번호
        public string HeadOfficeAddress {get; set;}
        public string HeadOfficeBunge {get; set;}
        public string HeadOfficeNumber {get; set;}
        public string HeadOfficeFax {get; set;}
        public string ClassifedCode {get; set;} // 국내공급처, 국외공급처
        public List<FinancialInfo> FinancialInfos {get; set;}
        public JournalCenter JournalCenter {get; set;}
    }
    public class Client : Entity
    {
        [Required] public string b_no { get; set; } // 사업자등록번호
        [Required] public string start_dt { get; set; } // 개업일자
        [Required] public string p_nm { get; set; } // 대표자성명
        public string p_nm_phoneNumber {get; set;}
        public string b_nm { get; set; } // 사업장 이름
        public string enus_bnm {get; set;} // 사업자 영문이름
        public string HomePageAddress {get; set;} // 홈페이지주소
        public string corp_no { get; set; } // 법인 등록번호
        public string b_sector { get; set; } // 주업태명
        public string b_type { get; set; } // 주종목명
        public bool IsHead {get; set;}
        public string ZipCode {get; set;} // 우편번호
        public string HeadOfficeAddress {get; set;}
        public string HeadOfficeBunge {get; set;}
        public string HeadOfficeNumber {get; set;}
        public string HeadOfficeFax {get; set;}
        public string ClassifedCode {get; set;} // 국내고객, 국외고객
        public List<FinancialInfo> FinancialInfos {get; set;}
        public JournalCenter JournalCenter {get; set;}
    }
    public class AccountInfo : Entity
    {
        public string CardNumber {get; set;}
        public string ProjectCode {get; set;}
        public string VendorClassifiedCode {get; set;}
        public string BankNumber {get; set;}
        public string BankCode {get; set;}
        public string AccountHolder {get; set;} //예금주
        public string AccountName {get; set;}
        public string KindsofAccount {get; set;}
        public JournalCenter JournalCenter {get; set;}
    }
    [Relation(typeof(JournalCenter), "JournalCenter")]
    [BackUpDbContext(typeof(BackUpJournalDbContext), DbConnectionString.BackUpJournalDbConnection)]
    [DbContext(typeof(JournalDbContext), DbConnectionString.JournalDbConnection)]
    [DataContext(typeof(JournalDataContext))]
    public class JournalCenter : Center
    {
        [Required] public string b_no { get; set; } // 사업자등록번호
        [Required] public string start_dt { get; set; } // 개업일자
        [Required] public string p_nm { get; set; } // 대표자성명
        public string p_nm_phoneNumber {get; set;}
        public string p_nm2 { get; set; } // 대표자성명2

        public string b_nm { get; set; } // 사업장 이름
        public string enus_bnm {get; set;} // 사업자 영문이름
        public string HomePageAddress {get; set;} // 홈페이지주소
        public string corp_no { get; set; } // 법인 등록번호

        public int TaxOffice {get; set;} // 관할세무서 코드
        public string b_sector { get; set; } // 주업태명
        public string b_type { get; set; } // 주종목명

        public string invoice_apply_dt { get; set; } // 세금계산서적용일자
        public string tax_type_change_dt { get; set; } // 최근과세유형전환일자
        public string utcc_yn { get; set; } // 단위과세전환폐업여부
        public string end_dt { get; set; } // 폐업일
        public string tax_type_cd { get; set; } // 과세유형메세지 (코드)
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
        public string tax_type { get; set; } // 과세유형메세지 (명칭)
        public string b_stt_cd { get; set; } // 납세자상태(코드) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
        public string b_stt { get; set; } // 납세자상태(명칭) 01 : 계속사업자 02 : 휴업자 03 : 폐업자
        public string ZipCode {get; set;} // 우편번호
        public bool IsHead {get; set;}
        public string HeadOfficeAddress {get; set;}
        public string HeadOfficeBunge {get; set;}
        public string HeadOfficeNumber {get; set;}
        public string HeadOfficeFax {get; set;}
       
        //public List<AccountInfo> AccountInfos {get; set;}
        public List<JCommodity> JCommodities { get; set; }
        //public List<UserSettingJournal> UserSettingJournals { get; set; }
        //public List<Vendor> Vendors {get; set;}
        //public List<Client> Clients {get; set;}
        public JournalCenter()
        {
            JCommodities = new();
            //UserSettingJournals = new();
        }
    }

    [BackUpDbContext(typeof(BackUpJournalDbContext), DbConnectionString.BackUpJournalDbConnection)]
    [DbContext(typeof(JournalDbContext), DbConnectionString.JournalDbConnection)]
    [DataContext(typeof(JournalDataContext))]
    public class JCommodity : Commodity
    {
        public string CommodityNo { get; set; }
        public List<Journal> Journals { get; set; }
        public JournalCenter JournalCenter { get; set; }
        public JCommodity()
        {
            Journals = new();
            JournalCenter = new();
        }
    }
    [BackUpDbContext(typeof(BackUpJournalDbContext), DbConnectionString.BackUpJournalDbConnection)]
    [DbContext(typeof(JournalDbContext), DbConnectionString.JournalDbConnection)]
    [DataContext(typeof(JournalDataContext))]
    public class Journal : Entity
    {
        public List<Debit> Debits { get; set; }         // Json 으로 처리한다.
        public List<Credit> Credits {get; set; }       // Json 으로 처리한다.
        public string AwesomeInfo {get; set;}
        public JCommodity JCommodity {get; set;}
        public Journal()
        {
            Debits = new();
            Credits = new();
            JCommodity = new();
        }
    }
    public class Debit : IComparer<Debit>
    {
        int Id { get; set; }
        public SubjectofAccounting SubjectofAccounting {get; set;}
        public double Money {get; set;}

        public int Compare(Debit x, Debit y)
        {
            if (x.Id > y.Id)
            {
                return 1;
            }
            if (x.Id < y.Id)
            {
                return -1;
            }
            return 0;
        }
    }
    public class Credit  : IComparer<Credit>
    {
        int Id { get; set; }
        public SubjectofAccounting SubjectofAccounting {get; set;}
        public double Money {get; set;}

        public int Compare(Credit x, Credit y)
        {
            if (x.Id > y.Id)
            {
                return 1;
            }
            if (x.Id < y.Id)
            {
                return -1;
            }
            return 0;
        }
    }
    
    public enum SubjectofAccounting
    {
        // ---- 당좌자산 ---- //
        // 현금 및 현금성자산
        현금,
        당좌예금, 
        보통예금, 
        현금성자산,

        // 단기 투자자산
        단기금융상품,
        단기대여금,
        단기매매증권,
        만기보유증권,
        매도가능증권,

        // 매출채권
        외상매출금,
        받을어음,
        대손충당금,

        미수금,
        미수수익,
        
        선급금,
        선급비용,
        소모품,
        가지급금,
        현금과부족,
        부가세대급금,
        선납세금,

        // ---- 재고자산 ---- 
        상품,
        제품,
        반제품,
        원재료,
        미착품,
        미착상품,
        재공품,

        // ---- 투자자산 ----
        장기투자자산,
        지분법적용투자주식,
        장기대여금,
        투자부동산,
        퇴직연금운용자산,
        특정현금과예금,

        // ---- 유형자산 ----
        토지,
        건물,
        구축물,
        기계장치,
        차량운반구,
        비품,
        건설중인자산,
        감가상각누계액,

        // ---- 무형자산 ----
        영업권,
        산업재산권,
        개발비,
        소프트웨어,

        // ---- 기타비유동자산 ----
        임차보증금,
        전세권,
        장기매출채권,
        장기미수금,
        부도어음과수표,
        이연법인세자산,

            /// ---- 부채 ---- //
        // ----- 유동부채 ---- //
        매입채무,
        미지급금,
        미지급비용,
        예수금,
        가수금,
        선수금,
        선수수익,
        단기차입금,
        부가세예수금,
        미지금세금,
        미지금배당금,
        유동성자기부채,

        // ---- 비유동부채 ---- //
        사채,
        장기차입금,
        임대보증금,
        퇴직급여충당부채,
        장기미지급금,
        이연법인세부채,

        /// ---- 자본 ---- ///
        // ---- 자본금 ---- //
        자본금,
        인출금,

        // ---- 자본잉여금 ---- //
        주식발행초과금,
        감자차익,
        자기주식처분이익,

        // ---- 자본조정 ---- //
        주식할인발행차금,
        감자차손,
        자기주식처분손실,
        자기주식,

        // ---- 기타포괄속인수계 ----
        매도가능증권평가손익,
        해외사업환산손익,
        현금흐름회피파생상품평가손익,
        재평가잉여금,

        // -- 이익잉여금 ----
        법정적립금,
        임의적립금,
        미처분이익잉여금,

        /// ---- 손익계산서 SubjectofAccounting ----///
        // 영업수익
        상품매출,
        제품매출,

        // 영업외수익
        이자수익,
        배당금수익,
        단기매매증권평가이익,
        단기매매증권처분이익,
        외환차익,
        외화환산이익,
        수수료수익,
        임대료,
        유형자산처분이익,
        투자자산처분이익,
        자산수증이익,
        채무면제이익,
        보험금수익,
        잡이익,

        /// 비용
        // 매출원가
        상품매출원가,
        제품매출원가,

        // 판매비와관리비
        급여,
        퇴직급여,
        복리후생비,
        여비교통비,
        접대비,
        통신비,
        수도광열비,
        세금과공과금,
        감가상각비,
        임차료,
        수선비,
        보험료, 
        차량유지비,
        운반비,
        도서인쇄비,
        소모품비,
        수수료비용,
        광고선전비,
        대손생각비,

        // 영업외비용
        이자비용,
        외환차손,
        기부금,
        외화환산손실,
        매출채권처분손실,
        단기매매증권평가손실,
        단기매매증권처분손실,
        재해손실,
        유형자산처분손실,
        투자자산처분손실,
        재고자산감모손실,
        잡손실,

        // 법인세비용
        법인세비용
    
        
    }
    
    
}
