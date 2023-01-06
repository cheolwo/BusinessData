using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofDTO.ofExternal
{
    public class KoreadAddressExternalDTO
    {
        public Common Common = new();
        public List<Juso> Jusos = new();
    }
    public class Common
    {
        public dynamic errorMessage { get; set; }
        public dynamic countPerPage { get; set; }
        public dynamic totalCount { get; set; }
        public dynamic errorCode { get; set; }
        public dynamic currentPage { get; set; }
    }

    public class Juso
    {
        public dynamic detBdNmList { get; set; }
        public dynamic engAddr { get; set; }
        public dynamic rn { get; set; }
        public dynamic emdNm { get; set; }
        public dynamic zipNo { get; set; }
        public dynamic roadAddrPart2 { get; set; }
        public dynamic emdNo { get; set; }
        public dynamic sggNm { get; set; }
        public dynamic jibunAddr { get; set; }
        public dynamic siNm { get; set; }
        public dynamic roadAddrPart1 { get; set; }
        public dynamic bdNm { get; set; }
        public dynamic admCd { get; set; }
        public dynamic udrtYn { get; set; }
        public dynamic lnbrMnnm { get; set; }
        public dynamic roadAddr { get; set; }
        public dynamic lnbrSlno { get; set; }
        public dynamic buldMnnm { get; set; }
        public dynamic bdKdcd { get; set; }
        public dynamic liNm { get; set; }
        public dynamic rnMgtSn { get; set; }
        public dynamic mtYn { get; set; }
        public dynamic bdMgtSn { get; set; }
        public dynamic buldSlno { get; set; }
    }

    public class Results
    {
        public Common common { get; set; }
        public List<Juso> juso { get; set; }
    }

    public class Root
    {
        public Results results { get; set; }
    }
}
