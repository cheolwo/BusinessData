using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    [NotMapped]
    public class Commodity : Entity, IRelatedCenter
    {
        public string? HsCode {get; set;}
        public string? Barcode {get; set;}
        public string? CenterId {get; set;}
        public Center? Center { get; set; }
        public List<EStatus> EStatuses { get; set; }
        public List<MStatus> MStatuses { get; set; }
        public List<SStatus> SStatuses { get; set; } 
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj is Commodity commodity &&
                   Name == commodity.Name &&
                   Barcode == commodity.Barcode;
        }

       public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, Barcode);
        }

        public virtual Center GetRelatedCenter()
        {
            return Center;
        }
    }
}
