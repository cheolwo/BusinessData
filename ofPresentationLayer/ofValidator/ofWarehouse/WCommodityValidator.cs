using BusinessData.ofPresentationLayer.ofDTO.ofWarehouse;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofWarehouse
{
    public class WCommodityValidator<TCommodity> : CommodityDTOValidator<TCommodity> where TCommodity : WCommodityDTO
    {
        public WCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TCommodity>.CreateWithOptions((TCommodity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}