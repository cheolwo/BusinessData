using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    [NotMapped]
    public class Doc : IComparable, IEqualityComparer<Doc>
    {
        [Key] public int Id {get; set;}
        public string FileName {get; set;}
        public string Info {get; set;}
        public string Purpose {get; set;}
        public int CompareTo(object obj)
        {
            if (obj == null) { return 1; }
            else
            {
                Doc Doc = obj as Doc;
                if (Doc != null) { return Id.CompareTo(Doc.Id); }
                else { throw new ArgumentNullException("obj is not Doc"); }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Doc doc &&
                   Id == doc.Id &&
                   FileName == doc.FileName &&
                   Info == doc.Info &&
                   Purpose == doc.Purpose;
        }

        public bool Equals(Doc x, Doc y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Id == y.Id
                && x.FileName == y.FileName
                && x.Info == y.Info
                && x.Purpose == y.Purpose)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FileName, Info, Purpose);
        }

        public int GetHashCode([DisallowNull] Doc obj)
        {
            return HashCode.Combine(obj.Id, obj.FileName, obj.Info, obj.Purpose);
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
