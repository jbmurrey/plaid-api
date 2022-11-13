namespace plaid_api.Data.Services
{
    public interface IHttp<T, V>
    {
        Task<V?> HttpPlaidPost(T _params, string path);
    }
}
