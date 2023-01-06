using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    [NotMapped]
    public class ImageofInfo : IComparable, IEqualityComparer<ImageofInfo>
    {
        [Key] public int Id {get; set;}
        public string fileName {get; set;}
        public string Info {get; set;}
        public string Purpose {get; set;}

        public int CompareTo(object obj)
        {
            if (obj == null) { return 1; }
            else
            {
                ImageofInfo imageofInfo = obj as ImageofInfo;
                if (imageofInfo != null) { return Id.CompareTo(imageofInfo.Id); }
                else { throw new ArgumentNullException("obj is not imageofInfo"); }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is ImageofInfo info &&
                   Id == info.Id &&
                   fileName == info.fileName &&
                   Info == info.Info &&
                   Purpose == info.Purpose;
        }

        public bool Equals(ImageofInfo x, ImageofInfo y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Id == y.Id && x.fileName == y.fileName)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] ImageofInfo imageofInfo)
        {
            return HashCode.Combine(imageofInfo.Id, imageofInfo.fileName);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, fileName);
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
