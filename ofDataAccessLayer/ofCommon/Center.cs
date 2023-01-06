using System.Collections.Generic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    [NotMapped]
    public class Center : Entity
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public int FailLogin { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public List<Commodity> Commodities { get; set; }
        public List<EStatus> EStatuses { get; set; }
        public List<MStatus> MStatuses { get; set; }
        public List<SStatus> SStatuses { get; set; }
        public List<CenterCard> CenterCards { get; set; }
        public List<CenterMacAddress> CenterMacAddresses { get; set; }
        public List<CenterIPAddress> CenterIPAddresses { get; set; }
        public List<CenterRole> CenterRoles { get; set; }
        public Center()
        {
            Commodities = new();
            EStatuses = new();
            MStatuses = new();
            SStatuses = new();
            CenterMacAddresses = new(); 
            CenterIPAddresses = new();
            CenterRoles = new();
            CenterCards = new();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && obj is Center center &&
                   Name == center.Name &&
                   UserId == center.UserId;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name, UserId);
        }

        public virtual Center GetRelatedCenter()
        {
            return this;
        }
    }
    [NotMapped]
    public class CenterCard : IEqualityComparer<CenterCard>
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string CardPassword { get; set; }
        [Key] public int Id { get; set; }
     
        public bool Equals(CenterCard x, CenterCard y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.CardNumber == y.CardNumber && x.Cvv == y.Cvv && x.CardPassword == y.CardPassword)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] CenterCard obj)
        {
            return HashCode.Combine(obj.CardPassword, obj.CardNumber, obj.Cvv);
        }
    }
}
