using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofPresentationLayer.ofDTO.ofCommon
{
    public class IdentityUserDTO : EntityDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }

        public Dictionary<string, List<PropertyInfo>> DictionaryforClassifiedPropertyByAttribute(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailManyProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailOneProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyDetailProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetManyProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetOneProperties(Type t)
        {
            throw new NotImplementedException();
        }

        public List<PropertyInfo> OnlyGetProperties(Type t)
        {
            throw new NotImplementedException();
        }
    }
}
