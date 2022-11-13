namespace plaid_api.Data.Models
{
    public class Options
    {
        public Options(string? webhook)
        {
            this.webhook = webhook;
        }

        public string? webhook { get; set; }
    }
}

