namespace plaid_api.Data.Services;

public interface IAuthenticator
{
    Task<string> getPublicToken(string client_id, string secret);
    Task<string> getAccessToken(string client_id, string secret, string public_token);
}
