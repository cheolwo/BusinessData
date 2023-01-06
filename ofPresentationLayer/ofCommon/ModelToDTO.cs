using BusinessData;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.Json;
using BusinessView.ofDTO.ofCommon;
using AutoMapper;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;

namespace BusinessData.ofPresentationLayer.ofCommon
{
    public interface IDTO
    {
        string GetServerUrl(bool IsProduct);
    }
    // 직렬화가 주요 개념
    public static class ModelDTOExtentions
    {
        public static DTO ConvertToDTO<DTO, Model>(this Model model) where Model : class where DTO : class, new()
        {
            return ModelToDTO<Model, DTO>.ConvertToDTO(model, new DTO());
        }
        public static Model ConvertToModel<Model, DTO>(this DTO dto) where DTO : class where Model : class, new()
        {
            return DTOToModel<DTO, Model>.ConvertToModel(dto, new Model());
        }
    }
    public class ModelToDTO<Model, DTO> where Model : class where DTO : class
    {
        public static PropertyInfo GetDTOPropertyByModelProp(PropertyInfo modepProp)
        {
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var prop in DTOProps)
            {
                if (prop.Name.Equals(modepProp.Name))
                {
                    return prop;
                }
            }
            return null;
        }
        public static DTO ConvertToDTO(Model model, DTO dto)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var prop in ModelProps)
            {
                var modelvalue = prop.GetValue(model);
                if (modelvalue is null)
                {
                    var dtoprop = GetDTOPropertyByModelProp(prop);
                    if(dtoprop == null) { continue; }
                    if (prop.PropertyType == typeof(int))
                    {
                        if (dtoprop != null) { dtoprop.SetValue(dto, InitializedValue.InitializedIntValue); }
                    }
                    if (prop.PropertyType == typeof(string))
                    {   

                        var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                        var One = dtoprop.GetCustomAttribute<OneAttribute>();
                        var Generic = dtoprop.GetCustomAttribute<GenericAttribute>();
                        if(Many is not null || One is not null || Generic is not null)
                        {
                             dtoprop.SetValue(dto, InitializedValue.InitializedStringValue);
                             continue;
                        }
                        var dtoProp = GetDTOPropertyByModelProp(prop);
                        if (dtoProp != null) { dtoProp.SetValue(dto, InitializedValue.InitializedStringValue); }
                        continue;
                    }
                }
                foreach (var dtoprop in DTOProps)
                {
                    if (dtoprop.Name.Equals(prop.Name))
                    {
                        var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                        var One = dtoprop.GetCustomAttribute<OneAttribute>();
                        var Generic  = dtoprop.GetCustomAttribute<GenericAttribute>();
                        if (Many is not null || One is not null || Generic is not null)
                        {
                            var dtovalue = JsonConvert.SerializeObject(modelvalue, Formatting.Indented);
                            dtoprop.SetValue(dto, dtovalue);
                            break;
                        }
                            dtoprop.SetValue(dto, modelvalue);
                            break;           
                    }
                }
            }
            return dto;
        }
    }
    public class DTOToModel<DTO, Model> where DTO : class where Model : class
    {
        public static PropertyInfo GetModelPropByDTOProp(PropertyInfo dtoProp)
        {
            var modelProp = typeof(Model).GetProperties();
            foreach (var prop in modelProp)
            {
                if (prop.Name.Equals(dtoProp.Name))
                {
                    return prop;
                }
            }
            return null;
        }
        public static Model ConvertToModel(DTO dto, Model model)
        {
            var ModelProps = typeof(Model).GetProperties();
            var DTOProps = typeof(DTO).GetProperties();
            foreach (var dtoprop in DTOProps)
            {
                var dtovalue = dtoprop.GetValue(dto);
                if(dtovalue is null || dtovalue.Equals("[]") || dtovalue.Equals("string"))
                {
                    var modelProp = GetModelPropByDTOProp(dtoprop);
                    if(modelProp == null) { continue; }
                    if(dtoprop.PropertyType == typeof(int))
                    {
                        modelProp.SetValue(model, InitializedValue.InitializedIntValue);
                    }
                    if(dtoprop.PropertyType == typeof(string))
                    {
                        var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                        var One = dtoprop.GetCustomAttribute<OneAttribute>();
                        var Generic = dtoprop.GetCustomAttribute<GenericAttribute>();
                        if(Many is not null || One is not null || Generic is not null)
                        {
                            if(Generic is not null)
                            {
                                var GenericObject = Activator.CreateInstance(Generic._t);
                                modelProp.SetValue(model, GenericObject); 
                                continue;
                            }
                            if(One is not null)
                            {
                                var OneObject = Activator.CreateInstance(One._t);
                                modelProp.SetValue(model, OneObject);
                                continue;
                            }
                            if(Many is not null)
                            {
                                var ManyObject = Activator.CreateInstance(Many._t);
                                modelProp.SetValue(model, ManyObject);
                                continue;
                            }
                        }
                        modelProp.SetValue(model, InitializedValue.InitializedStringValue);
                        continue;
                    }
                }
                foreach (var modelprop in ModelProps)
                {
                    if (dtoprop.Name.Equals(modelprop.Name))
                    {
                        if(dtoprop.PropertyType == typeof(int))
                        {
                            modelprop.SetValue(model, dtovalue);
                            break;
                        }
                        if(dtoprop.PropertyType == typeof(string))
                        {
                            var Many = dtoprop.GetCustomAttribute<ManyAttribute>();
                            var One = dtoprop.GetCustomAttribute<OneAttribute>();
                            var Generic = dtoprop.GetCustomAttribute<GenericAttribute>();
                            if(Many is not null || One is not null || Generic is not null)
                            {
                                if(Generic is not null)
                                {
                                    var DeserialObject = JsonConvert.DeserializeObject((string)dtovalue, Generic._t);
                                    modelprop.SetValue(model, DeserialObject);
                                    break;
                                }
                                if(One is not null)
                                {
                                    var DesirialObject = JsonConvert.DeserializeObject((string)dtovalue, One._t);
                                    modelprop.SetValue(model, DesirialObject);
                                    break;
                                }
                                if(Many is not null)
                                {
                                    var DesirialObject = JsonConvert.DeserializeObject((string)dtovalue, Many._t);
                                    modelprop.SetValue(model, DesirialObject);
                                    break;
                                }
                            }
                            modelprop.SetValue(model, dtovalue);
                            break;
                        }                        
                    }
                }
            }
            return model;
        }
    }
}
