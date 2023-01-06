using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessData.oEntityDTOManager.ofCommon
{
    public static class EntityQueryFilter
    {
        public static IEnumerable<Model> Filter<Model>(this IEnumerable<Model> list, Func<Model, bool> selector)
                                                                                    where Model : Entity
                => (from model in list where selector(model) select model).ToList();

        public static IEnumerable<DTO> ToDtos<Model, DTO>(this IEnumerable<Model> models) where Model : Entity, new() where DTO : EntityDTO, new()
        {
            List<DTO> dtos = new();
            foreach(var model in models)
            {
                dtos.Add(model.ConvertToDTO<DTO, Model>());
            }
            return dtos;
        }
        public static IEnumerable<Model> FileterByRemainedQuery<DTO, Model>(this IEnumerable<Model> Querylist, List<PropertyInfo> RemainedQuery, EntityQuery<DTO> entityQuery) where Model : Entity where DTO : EntityDTO, new()
        {
            foreach (var prop in RemainedQuery)
            {
                if (prop.Name == nameof(Entity.Code))
                {
                    Querylist = Querylist.Filter(e => e.Code.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.Name))
                {
                    Querylist = Querylist.Filter(e => e.Name.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.Container))
                {
                    Querylist = Querylist.Filter(e => e.Container.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.UserId))
                {
                    Querylist = Querylist.Filter(e => e.UserId.Equals(prop.GetValue(entityQuery)));
                }
                if (prop.Name == nameof(Entity.CreateTime))
                {
                    var time = (DateTime)prop.GetValue(entityQuery);
                    Querylist = Querylist.Filter(e => e.CreateTime < time);
                }
            }
            return Querylist;
        }
        public static string CreateQueryMethodName(string PropertyName, bool IsGetToList = true, bool IsRelated = true)
        {
            StringBuilder stringBuilder = new();
            if (IsGetToList) { stringBuilder.Append("GetToListBy"); stringBuilder.Append(PropertyName); }
            else { stringBuilder.Append("GetBy"); stringBuilder.Append(PropertyName); }
            if (IsRelated) { stringBuilder.Append("RelatedAsync"); }
            else { stringBuilder.Append("Async"); }
            return stringBuilder.ToString();
        }
    }
}
