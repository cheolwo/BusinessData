using System;
using System.Reflection;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices;
namespace BusinessData.ofPresendationLayer.ofCommon
{
    public static class DTOHttpServiceExtensions
    {
        public static DTOService GetHttpDTOService<T>(this T t) where T : class
        {
            var httpDTOServiceAttribute = typeof(T).GetCustomAttribute<HttpDTOServiceAttribute>();
            if(httpDTOServiceAttribute != null)
            {
                var ServiceOptions = new DTOServiceOptions();
                var dtoservice = (DTOService)Activator.CreateInstance(httpDTOServiceAttribute.GetType(), ServiceOptions);
                return dtoservice;
            }
            throw new ArgumentException("HttpDTOService Attribute Is Null");
        }
        public static DTOService GetHttpDTOService<T>(this T t, IServiceProvider seviceProvider) where T : class
        {
            var httpDTOServiceAttribute = typeof(T).GetCustomAttribute<HttpDTOServiceAttribute>();
            if(httpDTOServiceAttribute != null)
            {
                var ServiceOptions = (DTOServiceOptions)seviceProvider.GetService(typeof(DTOServiceOptions));
                if(ServiceOptions != null)
                {
                    var dtoservice = (DTOService)Activator.CreateInstance(t.GetType(), ServiceOptions);
                    return dtoservice;
                }
                throw new ArgumentException("Not Register Options To ServiceContainer");
            }
            throw new ArgumentException("HttpDTOService Arttribute Is Null");
        }
        public static T Post<T>(this T t) where T : class
        {
            throw new NotImplementedException();
        }
        public static int Add(this int value)
        {
            return value+value;
        }
        public static int Minus(this int value)
        {
            return value-value;
        }
        /*
            int Value = 10;
            Value.Add().Minus();
        */
    }
}