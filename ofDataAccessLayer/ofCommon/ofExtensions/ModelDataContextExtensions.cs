using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofExtensions
{
    // 업무분야별로 DbContext 라는 게 필요해보이기는 해.
    public static class ModelDataContextExtensions
    {
        public static DbContext CreateRelatedDbContext<TEntity>(this TEntity entity) where TEntity : IRelationable
        {
            var dbContextType = entity.GetDbContextType();
            var dbConnectionString = entity.GetDbConnetionString();
            var DbContext = (DbContext)Activator.CreateInstance(dbContextType, dbConnectionString);
            if(DbContext != null)
            {
                return DbContext;
            }
            throw new ArgumentException("Not Exist DbContext");
        }
        // Repository 모듈의 주입되느 DbContext는 메서드 내부에서 동적으로 생성되었다가
        // 메서드가 종료되면 해제가 되도록 만드는 게 바람직하지.
    }
}
