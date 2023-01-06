using BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofGroupOrder
{
    public class MGOCValidator<TMGOC> : MStatusDTOValidator<TMGOC> where TMGOC : MGOCDTO
    {
        public MGOCValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TMGOC>.CreateWithOptions((TMGOC)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}