using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofPresentationLayer.ofCommon
{
    public static class EntityDTOQueryExtensions
    {
        // 이런 걸 책임연쇄 패턴이라고 하는 거구나....
        public static List<PropertyInfo> GetByQueryAttribute(this EntityDTO entityDTO)
        {
            var props = typeof(EntityDTO).GetProperties();
            List<PropertyInfo> propIncludedQueryAttribute = new();
            foreach (var prop in props)
            {
                var QueryAttribute = prop.GetCustomAttribute<QueryAttribute>();
                if (QueryAttribute != null && prop.GetValue(entityDTO) != null)
                {
                    propIncludedQueryAttribute.Add(prop);
                }
            }
            return propIncludedQueryAttribute;
        }
        public static List<PropertyInfo> GetByQueryAttribute<DTO>(this EntityQuery<DTO> entityQuery) where DTO : EntityDTO, new()
        {
            var props = typeof(EntityQuery<DTO>).GetProperties();
            List<PropertyInfo> propIncludedQueryAttribute = new();
            foreach (var prop in props)
            {
                var QueryAttribute = prop.GetCustomAttribute<QueryAttribute>();
                if (QueryAttribute != null && prop.GetValue(entityQuery) != null)
                {
                    propIncludedQueryAttribute.Add(prop);
                }
            }
            var dtoprops = typeof(DTO).GetProperties();
            foreach (var prop in dtoprops)
            {
                var QueryAttribute = prop.GetCustomAttribute<QueryAttribute>();
                if (QueryAttribute != null && prop.GetValue(entityQuery.Dto) != null)
                {
                    propIncludedQueryAttribute.Add(prop);
                }
            }
            return propIncludedQueryAttribute;
        }
        public static Dictionary<QueryCode, List<PropertyInfo>> DistributedByQueryCode(this List<PropertyInfo> props)
        {
            Dictionary<QueryCode, List<PropertyInfo>> dictionary = new();
            List<PropertyInfo> KeyProps = new();
            List<PropertyInfo> ForeignProps = new();
            List<PropertyInfo> WithProps = new();
            List<PropertyInfo> StringProps = new();
            List<PropertyInfo> IntProps = new();
            List<PropertyInfo> TimeProps = new();

            dictionary.Add(QueryCode.Key, KeyProps);
            dictionary.Add(QueryCode.ForeignKey, ForeignProps);
            dictionary.Add(QueryCode.With, WithProps);
            dictionary.Add(QueryCode.String, StringProps);
            dictionary.Add(QueryCode.Int, IntProps);
            dictionary.Add(QueryCode.Time, TimeProps);

            foreach (var prop in props)
            {
                var query = prop.GetCustomAttribute<QueryAttribute>();
                if (query.QueryCode == QueryCode.Key)
                {
                    KeyProps = dictionary[QueryCode.Key];
                    KeyProps.Add(prop);
                    continue;
                }
                if (query.QueryCode == QueryCode.ForeignKey)
                {
                    ForeignProps = dictionary[QueryCode.ForeignKey];
                    ForeignProps.Add(prop);
                    continue;
                }
                if (query.QueryCode == QueryCode.With)
                {
                    WithProps = dictionary[QueryCode.With];
                    WithProps.Add(prop);
                    continue;
                }
                if (query.QueryCode == QueryCode.Time)
                {
                    TimeProps = dictionary[QueryCode.Time];
                    TimeProps.Add(prop);
                    continue;
                }
                if (query.QueryCode == QueryCode.String)
                {
                    StringProps = dictionary[QueryCode.String];
                    StringProps.Add(prop);
                    continue;
                }
                if (query.QueryCode == QueryCode.Int)
                {
                    IntProps = dictionary[QueryCode.Int];
                    IntProps.Add(prop);
                    continue;
                }
            }
            return dictionary;
        }
    }
}