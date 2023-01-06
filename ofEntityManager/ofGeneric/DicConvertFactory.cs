using System;
using System.Collections.Generic;
using BusinessData;
using BusinessData.ofDataAccessLayer.ofCommon;

namespace BusinessLogic.ofEntityManager.ofGeneric
{
    public class DicConvertFactory<TEntity> where TEntity : Entity
    {
        private Dictionary<int, TEntity> Dictionary { get; set; }
        public DicConvertFactory()
        {
            Dictionary = new Dictionary<int, TEntity>();
        }
        public Dictionary<int, TEntity> ConvertToHashTable(List<TEntity> entities)
        {
            if (entities != null)
            {
                foreach (var entity in entities)
                {
                    Dictionary.Add(entity.GetHashCode(), entity);
                }
                return Dictionary;
            }
            throw new ArgumentException("Entities is null");
        }
        public void Dispose()
        {
            Dictionary.Clear();
        }
    }
}