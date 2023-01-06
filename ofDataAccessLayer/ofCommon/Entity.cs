using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    public static class DbConnectionString
    {
        public const string WarehouseDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=WarehouseDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string HRDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=HRDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string DeliveryDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=DeliveryDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string MarketDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=MarketDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string JournalDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=JournalDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string OrderDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=OrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string GroupOrderDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=GroupOrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string ProductDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=ProductDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string TradeDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=TradeDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string HsDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=HsDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string KamisDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=KamisDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string KAptDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=KAptDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string FisheriesDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=FisheriesDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BusinessUserDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BusinessUserDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string OrderDbconnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=OrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string SmartFarmDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=SmartFarmDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";

        public const string BackUpWarehouseDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpWarehouseDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpHRDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpHRDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpDeliveryDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpDeliveryDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpMarketDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpMarketDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpJournalDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpJournalDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpOrderDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpOrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpGroupOrderDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpGroupOrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpProductDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpProductDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpTradeDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpTradeDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpHsDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpHsDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpKamisDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpKamisDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpKAptDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpKAptDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpFisheriesDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpFisheriesDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpBusinessUserDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpBusinessUserDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpOrderDbconnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpOrderDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
        public const string BackUpSmartFarmDbConnection = "Server=tcp:planlogisticsserver.database.windows.net,1433;Initial Catalog=BackUpSmartFarmDb;Persist Security Info=False;User ID=powerqkrcjfd;Password=;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=100";
    }
    public static class DevelopmentDbConnetionString
    {
        public const string WarehouseDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=WarehouseDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string HRDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=HRDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string DeliveryDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=DeliveryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string MarketDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=MarketDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string JournalDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=JournalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string OrderDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=OrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string GroupOrderDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=GroupOrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string ProductDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string TradeDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=TradeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string HsDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=HsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string KamisDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=KamisDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string KAptDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=KAptDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string FisheriesDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=FisheriesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BusinessUserDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BusinessUserDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string OrderDbconnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=OrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string SmartFarmDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=SmartFarmDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string IotDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=SmartFarmDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string IdentityDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=IdentityDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public const string BackUpWarehouseDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpWarehouseDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpHRDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpHRDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpDeliveryDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpDeliveryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpMarketDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpMarketDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpJournalDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpJournalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpOrderDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpOrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpGroupOrderDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpGroupOrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpProductDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpTradeDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpTradeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpHsDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpHsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpKamisDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpKamisDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpKAptDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpKAptDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpFisheriesDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpFisheriesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpBusinessUserDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpBusinessUserDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpOrderDbconnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpOrderDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpSmartFarmDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpSmartFarmDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpIotDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpSmartFarmDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public const string BackUpIdentityDbConnection = "Data Source=DESKTOP-HKC31JI\\SQLEXPRESS;Initial Catalog=BackUpIdentityDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class DbContextAttribute : Attribute
    {
        private Type _t;
        private string _dbConnectionsString;
        public DbContextAttribute(Type t, string DbConnectionsString)
        {
            _t = t;
            _dbConnectionsString = DbConnectionsString;
        }
        public Type t
        {
            get => _t;
        }
        public string DbConnectionString
        {
            get => _dbConnectionsString;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class BackUpDbContextAttribute : Attribute
    {
        private Type _t;
        private string _dbConnectionsString;
        public BackUpDbContextAttribute(Type t, string dbConnectionsString)
        {
            _t = t;
            _dbConnectionsString = dbConnectionsString;
        }
        public Type t
        {
            get => _t;
        }
        public string DbConnectionString
        {
            get => _dbConnectionsString;

        }
    }

     [AttributeUsage(AttributeTargets.Property)]
    public class OneAttribute : Attribute
    {     
        public string Name { get; set; }
        public Type _t {get; set;}
        public OneAttribute()
        {
            Name = "";
        }
        public OneAttribute(string name)
        {
            Name = name;
        }
        public OneAttribute(Type t)
        {
            Name = "";
            _t = t;
        }
        public OneAttribute(string name, Type t)
        {
            Name = name;
            _t = t;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ManyAttribute : Attribute
    {
        public string Name { get; set; }
        public Type _t {get; set;}
        public ManyAttribute()
        {
            Name = "null";
        }
        public ManyAttribute(string name)
        {
            Name = name;
        }
        public ManyAttribute(Type t)
        {
            Name = "";
            _t = t;
        }
        public ManyAttribute(string name, Type t)
        {
            Name = name;
            _t = t;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class GenericAttribute : Attribute
    {
        public Type _t { get; set; }
        public GenericAttribute()
        {

        }
        public GenericAttribute(Type t)
        {
            _t = t;
        }
    }
    public class OriginAttribute : Attribute
    {
        public Type _t {get; set;}
        public OriginAttribute(Type t)
        {
            _t = t;
        }
    }

    public class RescopeAttribute : Attribute
    {
        private string EntityCode { get; set; }
        private Type T { get; set; }
        public void SetEntityCode(string Code)
        {
            EntityCode = Code;
        }
        public void SetEntityType(Type t)
        {
            T = t;
        }
        public string GetEntityCode()
        {
            return EntityCode;
        }
        public Type GetEntityType()
        {
            return T;
        }
    }
    public class Entity : IComparable<Entity>, IComparable, IEquatable<Entity>, IComparer
    {
        [Key] public string Id { get; set; }
        [AllowNull] public string? Code { get; set; }
        [AllowNull] [MaxLength(500)] public string? Name { get; set; }
        [AllowNull]  public string Container { get; set; }
        public DateTime CreateTime { get; set; }
        public string? UserId { get; set; } // 이 부분은 인덱스로 만들어도 괜찮겠다.
        public List<ChangeUser> ChangedUsers { get; set; }
        public List<ImageofInfo> ImageofInfos { get; set; }
        public List<Doc> Docs { get; set; }
        public Entity()
        {
            ImageofInfos = new();
            ChangedUsers = new();
            Docs = new();
        }
        public string GetBasicCode()
        {
            var Splitvalues = Id.Split("-");
            return Splitvalues[0] + "-" + Splitvalues[Splitvalues.Length - 1];
        }
        public void SetRelation(Type type, string Code)
        {
            RelationAttribute RelationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(type, typeof(Entity));
            if (RelationAttribute != null)
            {
                RelationAttribute.SetRelation(type, Code);
            }
            throw new ArgumentException("Not Defined Rescope");
        }
        public override bool Equals(object obj)
        {
            return obj is Entity entity &&
                   Id == entity.Id &&
                   CreateTime == entity.CreateTime;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public virtual int GetHashCodeById()
        {
            return HashCode.Combine(Id);
        }
        public virtual string GetRelationCode(Type t)
        {
            RelationAttribute RelationAttribute = t.GetCustomAttribute<RelationAttribute>();
            if (RelationAttribute != null)
            {
                return RelationAttribute.GetEntityRelation();
            }
            throw new ArgumentException("Not Defined Relation Code");
        }
        public virtual string GetRelationCodeToLower(Type t)
        {
            RelationAttribute RelationAttribute = t.GetCustomAttribute<RelationAttribute>();
            if (RelationAttribute != null)
            {
                return RelationAttribute.GetEntityRelation().ToLower();
            }
            throw new ArgumentException("Not Defined Relation Code");
        }
        public virtual Type GetRelationType(Type t)
        {
            RelationAttribute RelationAttribute = t.GetCustomAttribute<RelationAttribute>();
            if (RelationAttribute != null)
            {
                return RelationAttribute.GetRelationType();
            }
            throw new ArgumentException("Not Defined Relation Type");
        }
        public Type GetDbContextType(Type t)
        {
            DbContextAttribute DbContextAttribute = (DbContextAttribute)Attribute.GetCustomAttribute(t, typeof(DbContextAttribute));
            if (DbContextAttribute != null)
            {
                return DbContextAttribute.t;
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public string GetDbConnetionString(Type t)
        {
            DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(t, typeof(DataContextAttribute));
            if (dataContextAttribute != null)
            {
                return dataContextAttribute.GetDbConnectionString();
            }
            throw new ArgumentException("Not Defined Relation");
        }
        public virtual IList<string> GetRelatedRoles(Type t)
        {
            AuthorizeAttribute AuthorizeAttribute = (AuthorizeAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorizeAttribute));
            if (AuthorizeAttribute != null)
            {
                return AuthorizeAttribute.Roles.Split(',').ToList();
            }
            throw new ArgumentException("Not Define Related Roles");
        }

        public int CompareTo(Entity other)
        {
            if (other == null) return 1;
            else
            {
                return CreateTime.CompareTo(other.CreateTime);
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else
            {
                Entity entity = obj as Entity;
                if (obj != null)
                {
                    return entity.CompareTo(entity);
                }
                else
                {
                    throw new ArgumentNullException("Obj Is Not Entity, Plase Input Entity");
                }
            }
        }

        public bool Equals(Entity other)
        {
            if (other == null) { throw new ArgumentNullException("Other Is Null"); }
            if (other.Code != null && other.Name != null)
            {
                return this.Code.Equals(other.Code) && this.Name.Equals(other.Name);
            }
            else
            {
                return this.Id.Equals(other.Id);
            }
        }

        public int Compare(object x, object y)
        {
            if (x == null || y == null) { throw new ArgumentNullException("Object Is Null"); }
            else
            {
                if (x is Entity Entityx)
                {
                    if (y is Entity Entityy)
                    {
                        if (Entityx.CreateTime.Ticks == Entityy.CreateTime.Ticks) { return 0; }
                        else if (Entityx.CreateTime.Ticks > Entityy.CreateTime.Ticks)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else { throw new ArgumentException("y is not Entity"); }
                }
                else { throw new ArgumentException("x is not Entity"); }
            }
        }

        public virtual Dictionary<string, List<PropertyInfo>> GetToDictionaryforClassifiedPropertyByAttribute()
        {
            throw new NotImplementedException();
        }
    }

    [NotMapped]
    public class CenterRole : Entity, IEqualityComparer<CenterRole>
    {
        public string Role { get; set; }
        public string Content { get; set; }

        public bool Equals(CenterRole x, CenterRole y)
        {
            if (x == null && y == null)
                return true;
            else if (x == null || y == null)
                return false;
            else if (x.Role == y.Role && x.Content == y.Content)
                return true;
            else
                return false;
        }

        public int GetHashCode([DisallowNull] CenterRole obj)
        {
            return HashCode.Combine(obj.Role, obj.Content);
        }
    }
    public static class NameofStatus
    {
        public const string SW = "SW";
        public const string MW = "MW";
        public const string EW = "EW";
        public const string SP = "SP";
        public const string MP = "MP";
        public const string EP = "EP";
        public const string SD = "SD";
        public const string MD = "MD";
        public const string ED = "ED";
    }
    [NotMapped]
    public class Status : Entity, IRelatedCenter
    {
        public string? CommodityId { get;  set; }
        public string? CenterId { get; set; }
        public int Quantity { get; set; }
        public Commodity? Commodity { get; set; }
        public Center? Center { get; set; }

        public virtual Center GetRelatedCenter()
        {
            return Center;
        }
    }
    [NotMapped]
    public class SStatus : Status
    {
        public List<MStatus> MStatuses { get; set; }
    }
    [NotMapped]
    public class MStatus : Status
    {
        public SStatus? SStatus { get; set; }
        public List<EStatus> EStatuses { get; set; }
    }
    [NotMapped]
    public class EStatus : Status
    {
        public MStatus? MStatus { get; set; }
    }
    public class RelationAttribute : Attribute
    {
        private string EntityRelation { get; set; }
        private Type t { get; set; }

        public RelationAttribute(Type RelationType, string entityRelation)
        {
            EntityRelation = entityRelation;
            t = RelationType;
        }
        public RelationAttribute()
        {
            EntityRelation = "Not Defined";
        }
        public void SetRelation(Type type, string entityRelation)
        {
            t = type;
            EntityRelation = entityRelation;
        }
        public Type GetRelationType()
        {
            return t;
        }
        public string GetEntityRelation()
        {
            return EntityRelation;
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
