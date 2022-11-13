using plaid_api.Data.DTO;
using plaid_api.Data.Models;

namespace plaid_api.Data.Services
{
    public interface ITransaction
    {
        Task<TransactionData?> getTransactions(TransactionDTO transactionDTO);
    }
}
