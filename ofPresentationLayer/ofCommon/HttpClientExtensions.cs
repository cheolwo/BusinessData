using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BusinessData.ofPresentationLayer.ofCommon
{
    public interface IHttpRequestParameter
    {
        IEnumerable<PropertyInfo> GetRequiredProps();
    }    
    public static class HttpClientExtensions
    {
        public static string GetUri<T>(string requestUri, T t) where T : class
        {
            var QueryStringParams = GetQueryStringParams(t);
            return GetUriWithQueryString(requestUri, QueryStringParams);
        }
        private static Dictionary<string, string> GetQueryStringParams<T>(T t) where T : class
        {
            var props = typeof(T).GetProperties();
            Dictionary<string, string> QueryStringParams = new();
            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(int))
                {
                    string value = prop.GetValue(t).ToString();
                    QueryStringParams.Add(prop.Name, value);
                }
                if (prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(t);
                    QueryStringParams.Add(prop.Name, value);
                }
                continue;
            }
            return QueryStringParams;
        }
        private static string GetUriWithQueryString(string requestUri,
                Dictionary<string, string> queryStringParams)
        {
            bool startingQuestionMarkAdded = false;
            var sb = new StringBuilder();
            sb.Append(requestUri);
            foreach (var parameter in queryStringParams)
            {
                if (parameter.Value == null)
                {
                    continue;
                }

                sb.Append(startingQuestionMarkAdded ? '&' : '?');
                sb.Append(parameter.Key);
                sb.Append('=');
                sb.Append(parameter.Value);
                startingQuestionMarkAdded = true;
            }
            return sb.ToString();
        }
        public static string GetUriByRequired<T>(string requestUri, T t) where T : IHttpRequestParameter
        {
            var QueryStringParams = GetQueryStringParamsByRequired(t);
            return GetUriWithQueryString(requestUri, QueryStringParams);
        }
        private static Dictionary<string, string> GetQueryStringParamsByRequired<T>(T t) where T : IHttpRequestParameter
        {
            var props = t.GetRequiredProps();
            Dictionary<string, string> QueryStringParams = new();
            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(int))
                {
                    string value = prop.GetValue(t).ToString();
                    QueryStringParams.Add(prop.Name, value);
                }
                if (prop.PropertyType == typeof(string))
                {
                    string value = (string)prop.GetValue(t);
                    QueryStringParams.Add(prop.Name, value);
                }
                continue;
            }
            return QueryStringParams;
        }
    }
}