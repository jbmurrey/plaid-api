namespace plaid_api.Data.DTO
{
    public class TransactionDTO
    {
        public TransactionDTO() { }
        public TransactionDTO(string client_id, string secret, string access_token, string start_date, string end_date)
        {
            this.client_id = client_id;
            this.secret = secret;
            this.access_token = access_token;
            this.start_date = start_date;
            this.end_date = end_date;
        }

        public string client_id { get; set; } = string.Empty;
        public string secret { get; set; } = string.Empty;
        public string access_token { get; set; } = string.Empty;
        public string start_date { get; set; } = string.Empty;
        public string end_date { get; set; } = string.Empty;
    }
}
