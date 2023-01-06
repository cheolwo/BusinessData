using FluentValidation;
using System;
using System.Collections.Generic;

namespace BusinessData.ofPresendationLayer.ofCommon.ofBuilder
{
    public class ValidatorBuilder
    {
        private Dictionary<int, IValidator> DicValidator { get; set; }
        public ValidatorBuilder()
        {
            DicValidator = new();
        }
        // Using // Actor : virtual void OnConfigureValidator(ValidatorBuilder ValidatorBuilder)
        public void Add(string nameofDTO, IValidator Validator)
        {
            DicValidator.Add(nameofDTO.GetHashCode(), Validator);
        }
        // Using // Actor : virtaul Add<T> (T t) where T : IViewModel
        // This Method Purpose is to Get Validator In Dictionay of Validators
        public IValidator Get(string nameofDTO)
        {
            return DicValidator[nameofDTO.GetHashCode()]
                   ?? throw new ArgumentNullException("Not Include Validator For ViewModel");
        }
    }
}
