

namespace plaid_api.Data.Models
{
    public class Item
    {
        public Item(string client_id, string secret, Options? options)
        {
            this.secret = secret;
            this.client_id = client_id;
            this.institution_id = "ins_3";
            this.initial_products[0] = "auth";
            this.options = options;
        }
        public string client_id { get; set; } = string.Empty;
        public string secret { get; set; } = string.Empty;
        public string institution_id { get; set; } = string.Empty;
        public string[] initial_products { get; set; } = new string[1];
        public Options? options { get; set; }
    }
}
