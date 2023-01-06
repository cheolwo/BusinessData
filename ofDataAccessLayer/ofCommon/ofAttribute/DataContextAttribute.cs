using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofAttribute
{
    public class DataContextAttribute : Attribute
    {
        private Type _dbContextType;
        private Type _dataContextType;
        private readonly string _DbConnectionString;

        public DataContextAttribute(Type DbContextType, string dbConnectionString, Type DataContextType)
        {
            _dbContextType = DbContextType;
            _DbConnectionString = dbConnectionString;
            _dataContextType = DataContextType;
        }
        public DataContextAttribute(Type DbContextType, string dbConnectionString)
        {
            _dbContextType = DbContextType;
            _DbConnectionString = dbConnectionString;
        }
        public DataContextAttribute(Type DataContextType)
        {
            _dataContextType = DataContextType;
        }
        public Type _DbContextType
        {
            get => _dbContextType;
        }
        public Type _DataContextType
        {
            get => _dataContextType;
        }
        public Type GetDbContextType()
        {
            return _dbContextType;
        }
        public string GetDbConnectionString()
        {
            return _DbConnectionString;
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
