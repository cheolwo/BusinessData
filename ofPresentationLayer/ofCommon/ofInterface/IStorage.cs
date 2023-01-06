using System.Threading.Tasks;
using System.Collections;

namespace BusinessData.ofPresendationLayer.ofCommon.ofInterface
{
    // public interface IStorage<TEntity> where TEntity : class
    // {
    //     void Add(TEntity entity);
    //     void Update(TEntity entity);
    //     void Delete(string id);
    //     TEntity GetById(string id);
    //     IEnumerable<TEntity> GetToList();
    // }
    // public interface IStorage
    // {
    //     void Add(Object entity);
    //     void Update(Object entity);
    //     void Delete(string id);
    //     Object GetById(string id);
    //     IEnumerable<Object> GetToList();
    // }
    // public class AbstractStorage<TEntity> : IStorage<TEntity>, IStorage where TEntity : class
    // {
    //     private Dictionary<string, TEntity> DicStorage = new();
    //     public AbstractStorage()
    //     {

    //     }

    //     public void Delete(string id)
    //     {
    //         var Value = DicStorage[id];
    //         if(Value == null) {throw new ArgumentNullException("Not Find Object");}
    //         DicStorage.Remove(id);
    //     }

    //     public TEntity GetById(string id)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public IEnumerable<TEntity> GetToList()
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public void Add(TEntity entity)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     public void Update(TEntity entity)
    //     {
    //         throw new NotImplementedException();
    //     }
    // }
}
