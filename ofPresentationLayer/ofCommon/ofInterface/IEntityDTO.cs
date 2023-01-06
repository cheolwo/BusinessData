using Microsoft.AspNetCore.Components.Forms;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.Collections.Generic;

namespace BusinessData.ofPresendationLayer.ofCommon.ofInterface
{
    public interface IEntityDTO
    {
        bool EqualsById(object obj);
        void BrowserFileToDTO(IList<IBrowserFile> files, EntityDTO entityDTO);
    }
}