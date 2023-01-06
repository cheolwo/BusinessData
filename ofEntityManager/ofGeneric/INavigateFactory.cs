using BusinessData;
using BusinessData.ofDataAccessLayer.ofCommon;
using System;

namespace BusinessLogic.ofEntityManager.ofGeneric
{
    public enum WhereOptions {Table, Card, DashBoard}
    public interface INavigateFactory<TEntity> where TEntity : Entity
    {
        string NavigateAfterCreate(WhereOptions options);
        string NavigateAfterDelte(WhereOptions options);
        string NavigateAfterUpdate(WhereOptions options);
    }

    public class NavigateFactory<TEntity> : INavigateFactory<TEntity> where TEntity : Entity
    {
        public virtual string NavigateAfterCreate(WhereOptions options)
        {
            return $"/Get/{options.ToString()}/{nameof(TEntity)}";
        }
        public virtual string NavigateAfterDelte(WhereOptions options)
        {
            return $"/Get/{options.ToString()}/{nameof(TEntity)}";
        }
        public virtual string NavigateAfterUpdate(WhereOptions options)
        {
            return $"/Get/{options.ToString()}/{nameof(TEntity)}";
        }
        // string NavigateAfterDetail(WhereOptions options)
        // {
        //     return $"/Get/{options.ToString()}";
        // }
    }
}
