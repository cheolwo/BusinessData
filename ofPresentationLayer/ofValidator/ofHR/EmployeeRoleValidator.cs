using BusinessData.ofPresentationLayer.ofDTO.ofHR;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BusinessData.ofPresentationLayer.ofValidator.ofCommon.ofHR
{
    public class EmployeeRoleValidator<TEntity> : EntityDTOValidator<TEntity> where TEntity : EmployeeRoleDTO
    {
        public EmployeeRoleValidator()
        {

        }
        public override Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<TEntity>.CreateWithOptions((TEntity)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}