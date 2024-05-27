using Mfund.Model;
using Mfund.Service.Interface;
using System.Net.Http.Headers;

namespace Mfund.Service
{
    public class GTTService : GTTInterface
    {
        private readonly HttpClient _httpClient;

        private readonly IConfiguration _configuration;

        public GTTService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }


        public async Task<GTTCreateRule> GTTCreateRuleAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var createGTTRule = apiUrls.GetValue<string>("createGTTRule");
            var request = new HttpRequestMessage(HttpMethod.Post, createGTTRule);

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
                return await response.Content.ReadFromJsonAsync<GTTCreateRule>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }


        public async Task<GTTModifyRule> GTTModifyRuleAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var modifyRuleUrl = apiUrls.GetValue<string>("modifyRuleUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, modifyRuleUrl);

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
                return await response.Content.ReadFromJsonAsync<GTTModifyRule>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<GTTCancelRule> GTTCancelRuleAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var cancelRuleUrl = apiUrls.GetValue<string>("cancelRuleUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, cancelRuleUrl);

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
                return await response.Content.ReadFromJsonAsync<GTTCancelRule>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<GTTRuleDetails> GTTRuleDetailsAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var cancelRuleUrl = apiUrls.GetValue<string>("cancelRuleUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, cancelRuleUrl);

            var response = await _httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<GTTRuleDetails>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<GTTRuleList> GTTRuleListAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var ruleListUrl = apiUrls.GetValue<string>("ruleListUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, ruleListUrl);

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
                return await response.Content.ReadFromJsonAsync<GTTRuleList>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }
    }
}
