namespace plaid_api.Data.Models
{
    public class TransactionData
    {
        public transactions[]? transactions { get; set; }
    }

    public class transactions
    {

        public double? amount { get; set; }
        public string? merchant_name { get; set; }
        public string[]? category { get; set; }
        public string? name { get; set; }
        public string? date { get; set; }
    }
}
