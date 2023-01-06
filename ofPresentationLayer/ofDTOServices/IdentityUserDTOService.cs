using BusinessData.ofPresendationLayer.ofDTOServices;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices
{
    public class IdentityService : DTOService
    {
        public IdentityService(DTOServiceOptions options)
              :base(options)
        {
            if (_DTOServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.IdentityWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
    public class IdentityUserDTOService : IdentityService, IDTOService<IdentityUserDTO>
    {
        public IdentityUserDTOService(DTOServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/IdentityUserDTO/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<IdentityUserDTO> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<IdentityUserDTO>($"/api/IdentityUserDTO/{id}");
        }

        public async Task<IEnumerable<IdentityUserDTO>> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<IdentityUserDTO>>("/api/IdentityUserDTO");
        }

        public async Task<IdentityUserDTO> PostAsync(IdentityUserDTO entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/IdentityUserDTO", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            IdentityUserDTO IdentityUserDTO = JsonSerializer.Deserialize<IdentityUserDTO>(JsonIdentityUserDTO);
            return IdentityUserDTO;
        }

        public async Task<IdentityUserDTO> PutAsync(IdentityUserDTO entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/IdentityUserDTO", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();

            IdentityUserDTO IdentityUserDTO = JsonSerializer.Deserialize<IdentityUserDTO>(JsonIdentityUserDTO);

            return IdentityUserDTO;
        }
    }
}
