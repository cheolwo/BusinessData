using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;
using System.Collections.Generic;
using System.Reflection;
namespace BusinessData.ofPresentationLayer.ofCommon
{
    public enum ComponentMode { Get, Detail }
    public static class PropertyClassification
    {
        public static Dictionary<string, int> ClassifyIntProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(int))
                    {
                        result.Add(prop.Name, new int());
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, string> ClassifyStringProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(string))
                    {
                        result.Add(prop.Name, string.Empty);
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, DateTime> ClassifyDateTimeProperty(IEnumerable<PropertyInfo> propertyInfos)
        {
            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();
            if (propertyInfos != null)
            {
                foreach (var prop in propertyInfos)
                {
                    if (prop.PropertyType == typeof(DateTime))
                    {
                        result.Add(prop.Name, new DateTime());
                    }
                }
            }
            return result;
        }
        public static Dictionary<string, DateTime?> ClassifyDateTimeProperty(ComponentMode mode, Type t)
        {
            Dictionary<string, DateTime?> result = new Dictionary<string, DateTime?>();
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(DateTime))
                        {
                            result.Add(prop.Name, new DateTime());
                        }
                    }
                }
                return result;
            }
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(DateTime))
                        {
                            result.Add(prop.Name, new DateTime());
                        }
                    }
                }
                return result;
            }
            return result;
        }
        public static Dictionary<string, string> ClassifyStringProperty(ComponentMode mode, Type t)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(string))
                        {
                            result.Add(prop.Name, string.Empty);
                        }
                    }
                }
                return result;
            }
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(string))
                        {
                            result.Add(prop.Name, string.Empty);
                        }
                    }
                }
                return result;
            }
            return result;
        }
        public static Dictionary<string, int> ClassifyIntProperty(ComponentMode mode, Type t)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            if (mode == ComponentMode.Get)
            {
                var propertyInfos = OnlyGetProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(int))
                        {
                            result.Add(prop.Name, new int());
                        }
                    }
                }
                return result;
            }
            if (mode == ComponentMode.Detail)
            {
                var propertyInfos = OnlyDetailProperties(t);
                if (propertyInfos != null)
                {
                    foreach (var prop in propertyInfos)
                    {
                        if (prop.PropertyType == typeof(int))
                        {
                            result.Add(prop.Name, new int());
                        }
                    }
                }
                return result;
            }
            return result;
        }
        public static List<PropertyInfo> OnlyGetProperties(Type t)
        {
            List<PropertyInfo> OnlyGetPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Get)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
                    {
                        OnlyGetPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyGetPropertyInfos;
        }
        public static List<PropertyInfo> OnlyDetailProperties(Type t)
        {
            List<PropertyInfo> OnlyDetailPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Detail)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (Many is null && One is null)
                    {
                        OnlyDetailPropertyInfos.Add(prop);
                    }
                }
            }
            return OnlyDetailPropertyInfos;
        }
        public static List<PropertyInfo> GetPropertiesByComponentMode(ComponentMode componentMode, Type t)
        {
            if (componentMode == ComponentMode.Get)
            {
                return OnlyGetProperties(t);
            }
            return OnlyDetailProperties(t);
        }

        public static List<PropertyInfo> OnlyGetManyProperties(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Get)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                    }
                }
            }
            return GetManyPropertyInfos;
        }

        public static List<PropertyInfo> OnlyGetOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Get)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public static List<PropertyInfo> OnlyDetailOneProperties(Type t)
        {
            List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Detail)
                {
                    var One = prop.GetCustomAttribute<OneAttribute>();
                    if (One != null)
                    {
                        GetOnePropertyInfos.Add(prop);
                    }
                }
            }
            return GetOnePropertyInfos;
        }

        public static List<PropertyInfo> OnlyDetailManyProperties(Type t)
        {
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Detail)
                {
                    var Many = prop.GetCustomAttribute<ManyAttribute>();
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                    }
                }
            }
            return DetailManyPropertyInfos;
        }
        public static Dictionary<string, List<PropertyInfo>> DictionaryforClassifiedPropertyByAttribute(Type t)
        {
            List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
            List<PropertyInfo> GetOneInfos = new List<PropertyInfo>();
            List<PropertyInfo> DetailOneInfos = new List<PropertyInfo>();

            var props = t.GetProperties();
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Get)
                {
                    if (Many != null)
                    {
                        GetManyPropertyInfos.Add(prop);
                        continue;
                    }
                    GetPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var Many = prop.GetCustomAttribute<ManyAttribute>();
                var View = prop.GetCustomAttribute<ViewAttribute>();
                if (View != null && View._ViewMode == ofDTO.ofCommon.ViewMode.Detail)
                {
                    if (Many != null)
                    {
                        DetailManyPropertyInfos.Add(prop);
                        continue;
                    }
                    DetailPropertyInfos.Add(prop);
                }
            }
            foreach (var prop in props)
            {
                var One = prop.GetCustomAttribute<OneAttribute>();
                var Get = prop.GetCustomAttribute<GetAttribute>();
                var Detail = prop.GetCustomAttribute<DetailAttribute>();

                if (One != null)
                {
                    if (Get != null)
                    {
                        GetOneInfos.Add(prop);
                        continue;
                    }
                    if (Detail != null)
                    {
                        DetailOneInfos.Add(prop);
                        continue;
                    }
                }
            }
            Dictionary<string, List<PropertyInfo>> keyValuePairs = new();
            keyValuePairs.Add(TableMetaInfo.Get, GetPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetMany, GetManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.Detail, DetailPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.DetailMany, DetailManyPropertyInfos);
            keyValuePairs.Add(TableMetaInfo.GetOne, GetOneInfos);
            keyValuePairs.Add(TableMetaInfo.DetailOne, DetailOneInfos);
            return keyValuePairs;
        }

    }
}
