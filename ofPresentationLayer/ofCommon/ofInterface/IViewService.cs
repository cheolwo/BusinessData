using BusinessData.ofPresentationLayer.ofCommon;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofPresendationLayer.ofCommon.ofInterface
{
    public interface IViewService<T> where T : IDTO
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
    }
    public interface IViewService
    {

    }

}
