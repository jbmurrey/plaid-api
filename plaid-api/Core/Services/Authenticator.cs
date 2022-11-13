using plaid_api.Data.Models;

namespace plaid_api.Data.Services
{
    public class Authenticator : IAuthenticator
    {
        private readonly IHttp<Item, ItemResponse> _httpPublicToken;
        private readonly IHttp<AccessToken, AccessTokenResponse> _httpAccessToken;

        public Authenticator(IHttp<Item, ItemResponse> httpPublicToken, IHttp<AccessToken, AccessTokenResponse> httpAccessToken)
        {
            _httpPublicToken = httpPublicToken;
            _httpAccessToken = httpAccessToken;
        }
        public async Task<string> getPublicToken(string client_id, string secret)
        {

            Options options = new Options("https://www.genericwebhookurl.com/webhook");
            Item _params = new Item(client_id, secret, options);
            ItemResponse? token = await _httpPublicToken.HttpPlaidPost(_params, "/sandbox/public_token/create");
            if (token != null && token.public_token != null)
            {
                return token.public_token;
            }
            return "public token not found";
        }
        public async Task<string> getAccessToken(string client_id, string secret, string public_token)
        {
            AccessToken _params = new AccessToken(client_id, secret, public_token);
            AccessTokenResponse? response = await _httpAccessToken.HttpPlaidPost(_params, "/item/public_token/exchange");
            var token = response?.access_token;
            if (token != null)
            {
                return token;
            }
            return " access token not found";
        }
    }
}
