using plaid_api.Data.DTO;
using plaid_api.Data.Models;

namespace plaid_api.Data.Services
{
    public class Transaction : ITransaction
    {
        private readonly IHttp<TransactionDTO, TransactionData> _transacitonHttp;

        public Transaction(IHttp<TransactionDTO, TransactionData> transacitonHttp)
        {
            _transacitonHttp = transacitonHttp;
        }

        public async Task<TransactionData?> getTransactions(TransactionDTO _params)
        {

            TransactionData? token = await _transacitonHttp.HttpPlaidPost(_params, "/transactions/get");
            TransactionData failed = new TransactionData();
            return token;
        }
    }
}
