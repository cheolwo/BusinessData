using AutoMapper;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessData.ofPresentationLayer.ofDTOServices
{
    public static class DevelopmentServerBaseAddress
    {
        public const string WarehouseWebAPIServerURL = "https://localhost:7025";
        public const string GroupOrderWebAPIServerURL = "https://localhost:7283";
        public const string HRWebAPIServerURL = "https://localhost:7148";
        public const string IdentityWebAPIServerURL = "https://localhost:7271";
        public const string JournalWebAPIServerURL = "https://localhost:7159";
        public const string OrderWebAPIServerURL = "https://localhost:7242";
        public const string ProductWebAPIServerURL = "https://localhost:7172";
        public const string TradeWebAPIServerURL = "https://localhost:7074";
        public const string MarketWebAPIServerURL = "https://localhost:7074";
    }
    public static class ProductServerBaseAddress
    {
        public const string WarehouseWebAPIServerURL = "https://localhost:7025";
        public const string GOCWebAPIServerURL = "https://localhost:7283";
        public const string HRWebAPIServerURL = "https://localhost:7148";
        public const string IdentityWebAPIServerURL = "https://localhost:7148";
        public const string JournalWebAPIServerURL = "https://localhost:7159";
        public const string OCWebAPIServerURL = "https://localhost:7242";
        public const string ProductWebAPIServerURL = "https://localhost:7172";
        public const string TradeWebAPIServerURL = "https://localhost:7074";
        public const string MarketWebAPIServerURL = "https://localhost:7074";
    }
    public interface IDTOService<T> where T : class
    {
        Task<IEnumerable<T>> GetsAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> PostAsync(T entity);
        Task DeleteAsync(string id);
        Task<T> PutAsync(T entity);
    }
    public class DTOServiceOptions
    {
        public bool IsDevelopment = true;
    }
    public class DTOService
    {
        protected HttpClient _httpClient = new();
        protected DTOServiceOptions _DTOServiceOptions;
        public DTOService(DTOServiceOptions options)
        {
            _DTOServiceOptions = options;
        }
        public virtual async Task<T> PostAsync<T>(T t, MultipartFormDataContent content) where T : new()
        {
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(t),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
               await _httpClient.PostAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            var response = await _httpClient.PostAsync("/api/Filesave", content);
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                using var responseStream =
                    await response.Content.ReadAsStreamAsync();
            }

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            T dto = JsonSerializer.Deserialize<T>(JsonIdentityUserDTO);
            return dto;
        }
        public virtual async Task<T> PostAsync<T>(T t) where T :  class, new()
        {
            AutoMapAttribute autoMapAttribute = (AutoMapAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(AutoMapAttribute));
            if(autoMapAttribute == null ) { throw new ArgumentException("NOT_INCLUDE_ORIGINATTRIBUTE"); }
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(t),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            //var configuration = new MapperConfiguration(cfg => cfg.AddMaps("BusinessView"));
            //var mapper = new Mapper(configuration);

            using var httpResponseMessage =
               await _httpClient.PostAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();
            var value = await httpResponseMessage.Content.ReadFromJsonAsync<T>();
            return value;
        }
        public virtual async Task<T> PutAsync<T>(T t) where T : new()
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(t),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage =
               await _httpClient.PutAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string jsonDto = await httpResponseMessage.Content.ReadAsStringAsync();
            T dto = JsonSerializer.Deserialize<T>(jsonDto);
            return dto;
        }
        public virtual async Task DeleteAsync<T>(string id) where T : new()
        {
            var Response = await _httpClient.DeleteAsync($"api/{typeof(T).Name}/{id}");
            Response.EnsureSuccessStatusCode();
        }
        public virtual async Task<T> GetByIdAsync<T>(string id) where T : new()
        {
            return await _httpClient.GetFromJsonAsync<T>($"/api/{typeof(T).Name}/{id}");
        }
        public virtual async Task<IEnumerable<T>> GetsAsync<T>() where T : new()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>>($"/api/{typeof(T).Name}");
        }
        public virtual async Task<IEnumerable<T>> GetsAsync<T>(T t) where T : new()
        {
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(t),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage = await _httpClient.PostAsync($"/api/{typeof(T).Name}/Alls", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();
            string jsonDto = await httpResponseMessage.Content.ReadAsStringAsync();
            List<T> dto = JsonSerializer.Deserialize<List<T>>(jsonDto);
            return dto;
        }
        public virtual async Task<IEnumerable<T>> GetAsynByQuery<T>(EntityQuery<T> entityQuery) where T : EntityDTO, new()
        {
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(entityQuery),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage = await _httpClient.PostAsync($"/api/{typeof(T).Name}/Searching", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();
            string jsonDto = await httpResponseMessage.Content.ReadAsStringAsync();
            List<T> dto = JsonSerializer.Deserialize<List<T>>(jsonDto);
            return dto;
        }
        public virtual async Task<IEnumerable<T>> GetsAsyncByUserId<T>(string userid) where T : new()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>>($"/api/{typeof(T).Name}/User?{userid}");
        }
    }
    //public class DTOService
    //{
    //    protected HttpClient _httpClient = new();
    //    private DTOServiceOptions _options = new();
    //    public DTOService(Action<DTOServiceOptions> options)
    //    {
    //        options.Invoke(_options);
    //    }
    //}

}
