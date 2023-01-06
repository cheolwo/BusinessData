using System;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofInterface
{
    public interface IRelationable
    {
        string GetRelationCode();
        Type GetDbContextType();
        string GetDbConnetionString();     
    }
}
