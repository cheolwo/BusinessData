using BusinessData.ofPresentationLayer.ofDTO.ofTrade;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofTrade
{
    public class STCommodityValidator<TSStatus> : SStatusDTOValidator<TSStatus> where TSStatus : STCommodityDTO
    {
        public STCommodityValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TSStatus>.CreateWithOptions((TSStatus)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}