namespace plaid_api.Data.Models
{
    public class AccessToken
    {
        public AccessToken(string client_id, string secret, string public_token)
        {
            this.client_id = client_id;
            this.secret = secret;
            this.public_token = public_token;
        }
        public string client_id { get; set; } = string.Empty;
        public string secret { get; set; } = string.Empty;
        public string public_token { get; set; } = string.Empty;
    }
}
