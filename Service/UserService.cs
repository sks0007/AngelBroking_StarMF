using Mfund.Model;
using System.Net.Http.Headers;

namespace MutualFund.Service
{
    public class UserService : Interface.IUser
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public UserService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<LoginServices> LoginAsync()
        {
            var apiUrls = _configuration.GetSection("Mutualfund");
            var loginUrl = apiUrls.GetValue<string>("loginUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, loginUrl);

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
                return await response.Content.ReadFromJsonAsync<LoginServices>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }

        public async Task<Token> TokenAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var generatetokenUrl = apiUrl.GetValue<string>("generatetokenUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, generatetokenUrl);

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
                return await response.Content.ReadFromJsonAsync<Token>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }

        }
        public async Task<GetProfile> GetProfileAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var getprofileUrl = apiUrl.GetValue<string>("getprofileUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, getprofileUrl);

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
                return await response.Content.ReadFromJsonAsync<GetProfile>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<GetRMS> GetRMSAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var rmsUrl = apiUrl.GetValue<string>("rmsUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, rmsUrl);

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
                return await response.Content.ReadFromJsonAsync<GetRMS>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<logOut> logOutAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var logoutUrl = apiUrl.GetValue<string>("logoutUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, logoutUrl);

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
                return await response.Content.ReadFromJsonAsync<logOut>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}
