using Mfund.Model;
using Mfund.Service.Interface;
using System.Net.Http.Headers;

namespace Mfund.Service
{
    public class PortfolioService : PortfolioInterface
    {
        private readonly HttpClient _httpClient;

        private readonly IConfiguration _configuration;

        public PortfolioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;   
            _configuration = configuration; 
        }

        public async Task<PortfolioGetHolding> GetHoldingAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var getHoldingUrl = apiUrls.GetValue<string>("getHoldingUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, getHoldingUrl);


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
                return await response.Content.ReadFromJsonAsync<PortfolioGetHolding>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<PortfolioGetAllHoldings> GetAllHoldingsAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var getAllHoldingUrl = apiUrls.GetValue<string>("getAllHoldingUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, getAllHoldingUrl);


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
                return await response.Content.ReadFromJsonAsync<PortfolioGetAllHoldings>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<PortfolioGetPosition> GetPositionAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var getPosition = apiUrls.GetValue<string>("getPosition");
            var request = new HttpRequestMessage(HttpMethod.Get, getPosition);


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
                return await response.Content.ReadFromJsonAsync<PortfolioGetPosition>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<PortfolioConvertPosition> ConvertPositionAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var convertPositionUrl = apiUrls.GetValue<string>("convertPositionUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, convertPositionUrl);


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
                return await response.Content.ReadFromJsonAsync<PortfolioConvertPosition>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }
    }
}
