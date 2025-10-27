using System.Net.Http;
using System.Net.Http.Headers;

namespace WhoerVpnApi
{
    public class WhoerVpn
    {
        private string accountCode;
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://secwhapi.net/ru/vpn/api";
        public WhoerVpn()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0");
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> LoginByCode(string accountCode)
        {
            accountCode = accountCode;
            return accountCode;
        }
        public async Task<string> GetAccountInfo()
        {
            var response = await httpClient.PostAsync($"{apiUrl}/info?code={accountCode}", null);
            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> GetProxies()
        {
            var response = await httpClient.PostAsync($"{apiUrl}/proxies?code={accountCode}", null);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
