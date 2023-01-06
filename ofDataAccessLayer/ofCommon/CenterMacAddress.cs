using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    [NotMapped]
    public class CenterMacAddress : IEqualityComparer<CenterMacAddress>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        [Key] public int Id { get; set; }

        public bool Equals(CenterMacAddress x, CenterMacAddress y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Id == y.Id && x.Name == y.Name && x.Address == y.Address)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] CenterMacAddress obj)
        {
            return HashCode.Combine(obj.Id, obj.Name, obj.Address);
        }
    }

    // public class Journal : Attribute
    // {
    //     private string Debit {get; set;}
    //     private string Credit {get; set;}

    //     public Journal(string Debit, string Credit)
    //     {
    //         this.Debit = Debit;
    //         this.Credit = Credit;
    //     }
    //     public Journal()
    //     {
            
    //     }
    //     public string GetDebit()
    //     {
    //         return this.Debit;
    //     }
    //     public string GetCredit()
    //     {
    //         return this.Credit;
    //     }
    //     public void SetDebit(string Debit)
    //     {
    //         this.Debit = Debit;
    //     }
    //     public void SetCredit(string Credit)
    //     {
    //         this.Credit = Credit;
    //     }
    // }
}
