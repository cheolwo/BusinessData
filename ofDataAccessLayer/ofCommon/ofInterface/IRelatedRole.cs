using System;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofInterface
{
    public interface IRelatedRoles
    {
        IList<string> GetRelatedRoles(Type t);
    }
}
