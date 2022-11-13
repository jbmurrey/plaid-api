using Microsoft.AspNetCore.Mvc;
using plaid_api.Data.DTO;
using plaid_api.Data.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace plaid_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Plaid : ControllerBase
    {

        private readonly IAuthenticator _auth;
        private readonly ITransaction _transcation;
        public Plaid(IAuthenticator auth, ITransaction transcation)
        {
            _auth = auth;
            _transcation = transcation;
        }

        [HttpGet("/creds")]
        public AuthDTO getCreds()
        {
            AuthDTO _params = new AuthDTO()
            {
                client_id = "63616680ec3d1400135bf5e5",
                secret = "de6f403650b1fff2c97f810b479b52"
            };
            return _params;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<string>> Authenticate(AuthDTO authDTO)
        {
            try
            {
                var public_token = await _auth.getPublicToken(authDTO.client_id, authDTO.secret);
                var access_token = await _auth.getAccessToken(authDTO.client_id, authDTO.secret, public_token);
                return Ok(access_token);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPost("/transactions")]
        public async Task<ActionResult<TransactionDTO>> getTransactions(TransactionDTO transactionDTO)
        {

            try
            {
                var transactions = await _transcation.getTransactions(transactionDTO);
                return Ok(transactions);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
