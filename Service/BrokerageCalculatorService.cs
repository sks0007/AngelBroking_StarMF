using Mfund.Model;
using Mfund.Service.Interface;
using System.Net.Http.Headers;

namespace Mfund.Service
{
    public class BrokerageCalculatorService : BrokerageCalculatorInterface
    {
        private readonly HttpClient _httpClient;

        private readonly IConfiguration _configuration;

        public BrokerageCalculatorService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<BrokerageCalculator> BrokageCalculatorAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var brokerageCalculatorUrl = apiUrls.GetValue<string>("brokerageCalculatorUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, brokerageCalculatorUrl);

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "AUTHORIZATION_TOKEN");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("X-UserType", "USER");
            request.Headers.Add("X-SourceID", "WEB");
            request.Headers.Add("X-ClientLocalIP", "CLIENT_LOCAL_IP");
            request.Headers.Add("X-ClientPublicIP", "CLIENT_PUBLIC_IP");
            request.Headers.Add("X-MACAddress", "MAC_ADDRESS");
            request.Headers.Add("X-PrivateKey", "API_KEY");

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<BrokerageCalculator>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }
    }
}
