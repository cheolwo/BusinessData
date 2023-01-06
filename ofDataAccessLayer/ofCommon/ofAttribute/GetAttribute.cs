using System.Collections.Generic;
using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GetAttribute : Attribute
    {
        public string NameofView { get; set; }    
        public GetAttribute()
        {

        }
        public GetAttribute(string NameofView)
        {
            this.NameofView = NameofView;   
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
