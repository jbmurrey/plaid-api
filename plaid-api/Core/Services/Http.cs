using plaid_api.Data.Models;

namespace plaid_api.Data.Services
{
    public class Http<T, V> : IHttp<T, V>
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Http(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<V?> HttpPlaidPost(T _params, string path)
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri("https://sandbox.plaid.com");
            Options options = new Options("https://www.genericwebhookurl.com/webhook");
            V? res;
            var httpResponseMessage = await httpClient.PostAsJsonAsync(path, _params);
            res = await httpResponseMessage.Content.ReadFromJsonAsync<V>();
            return res;
        }
    }
}
