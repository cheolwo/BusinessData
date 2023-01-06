using System.Collections.Generic;
using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DetailAttribute : Attribute
    {
        public List<string> NameofViews = new();
        public DetailAttribute()
        {
        }
        public DetailAttribute(string NameofView)
        {
            NameofViews.Add(NameofView);
        }
        public DetailAttribute(List<string> NameofView)
        {
            foreach (var item in NameofView)
            {
                NameofViews.Add(item);
            }
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
