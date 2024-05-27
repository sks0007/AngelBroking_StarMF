using Mfund.Model;
using Mfund.Service.Interface;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Mfund.Service
{
    public class EDIsAPIsService : EDIsAPIsInterface
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public EDIsAPIsService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<CDSL> CDSLAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var cdslUrl = apiUrl.GetValue<string>("cdslUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, cdslUrl);

            

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CDSL>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<GenerateTPIN> GenerateTPINAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var tpinUrl = apiUrl.GetValue<string>("tpinUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, tpinUrl);

            var response = await _httpClient.SendAsync(request);

            if(response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GenerateTPIN>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode},{response.ReasonPhrase}");
            }


        }

        public async Task<GetTransactionStatusAPI> GetTransactionStatusAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var transactionStatusUrl = apiUrl.GetValue<string>("transactionStatusUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, transactionStatusUrl);

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GetTransactionStatusAPI>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode},{response.ReasonPhrase}");
            }
        }
    }
}
