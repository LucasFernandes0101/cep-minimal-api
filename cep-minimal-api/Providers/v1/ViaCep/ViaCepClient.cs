using cep_minimal_api.Providers.v1.ViaCep.Models;
using Newtonsoft.Json;
using System.Net;

namespace cep_minimal_api.Providers.v1.ViaCep
{
    public class ViaCepClient
    {
        private readonly HttpClient _httpClient;

        public ViaCepClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Address> GetAddressByCep(string cep)
        {
            cep = cep.Trim();

            var result = await _httpClient.GetAsync($"{cep}/json");

            Address response = new();

            string content = await result.Content.ReadAsStringAsync();

            response = JsonConvert.DeserializeObject<Address>(content) ?? new Address();

            return response;
        }
    }
}
