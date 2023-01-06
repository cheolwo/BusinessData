using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    /*
     *  Less than zero a is less than b.
        Zero	a equals b.
        Greater than zero	a is greater than b.
     */
    [NotMapped]
    public class ChangeUser : IComparable, IComparer, IEqualityComparer<ChangeUser>
    {
        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }

        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) { return 1; }
            else
            {
                ChangeUser user = obj as ChangeUser;
                if(user != null) { return Id.CompareTo(user.Id); }
                else { throw new ArgumentNullException("Converted Obj To User Is Null"); }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is ChangeUser user &&
                   Id == user.Id &&
                   UserId == user.UserId &&
                   Name == user.Name;
        }

        public bool Equals(ChangeUser x, ChangeUser y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Id == y.Id && x.UserId == y.UserId
                                && x.Name == y.Name)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, UserId, Name);
        }

        public int GetHashCode([DisallowNull] ChangeUser obj)
        {
            return HashCode.Combine(obj.Id, obj.UserId, obj.Name);
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
