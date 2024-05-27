using Mfund.Model;
using Mfund.Service.Interface;
using System.Net.Http.Headers;

namespace Mfund.Service
{
    public class OrderService : OrderInterface
    {
        private readonly HttpClient _httpClient;    
        private readonly IConfiguration _configuration; 

        public OrderService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        } 
        
        public async Task<OrderPlaceOrder> PlaceOrderAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var placeOrderUrl = apiUrls.GetValue<string>("placeOrderUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, placeOrderUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderPlaceOrder>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<OrderModifyOrder> ModifyOrderAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var modifyOrderUrl = apiUrls.GetValue<string>("modifyOrderUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, modifyOrderUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderModifyOrder>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<OrderCancelOrder> CancelOrderAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var cancelOrderUrl = apiUrls.GetValue<string>("cancelOrderUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, cancelOrderUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderCancelOrder>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<OrderGetOrderBook> GetOrderBookAsync()
        {

            var apiUrls = _configuration.GetSection("Mutualfund");
            var orderBookUrl = apiUrls.GetValue<string>("orderBookUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, orderBookUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderGetOrderBook>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
        public async Task<OrderGetTradeBook> GetTradeBookAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var tradeBookUrl = apiUrl.GetValue<string>("tradeBookUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, tradeBookUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderGetTradeBook>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<OrderGetLtpData> GetLTPDataAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var LTPDataUrl = apiUrl.GetValue<string>("LTPDataUrl");
            var request = new HttpRequestMessage(HttpMethod.Post, LTPDataUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderGetLtpData>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<OrderIndividualOrderStatus> IndividualOrderStatusAsync()
        {
            var apiUrl = _configuration.GetSection("Mutualfund");
            var individualorderStatusUrl = apiUrl.GetValue<string>("individualorderStatusUrl");
            var request = new HttpRequestMessage(HttpMethod.Get, individualorderStatusUrl);

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
                return await response.Content.ReadFromJsonAsync<OrderIndividualOrderStatus>();
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }

}
