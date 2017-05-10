using JukeBox.Models;
using Square.Connect.Api;
using Square.Connect.Model;
using System;
using System.Web.Http;

namespace JukeBox.Controllers
{
    public class PaymentController : ApiController
    {
        private static TransactionApi _transactionApi;
        private static string _accessToken = "sandbox-sq0atb-HS3WN-Tl31jkwNd5IfLFOQ";
        private static string _locationId = "CBASEBsfwySf3csXbi2K_lLCZ1wgAQ";

        public PaymentController()
        {
            _transactionApi = new TransactionApi();
        }

        [HttpPost]
        public IHttpActionResult PayForCredits(PaymentModel model)
        {
            int centsAmount = model.CreditAmount * 10;
            Money amount = NewMoney(centsAmount, "USD");
            string nonce = model.Nonce;

            string uuid = NewIdempotencyKey();

            ChargeRequest body = new ChargeRequest(AmountMoney: amount, IdempotencyKey: uuid, CardNonce: nonce);
            var response = _transactionApi.Charge(_accessToken, _locationId, body);

            if (response.Errors == null)
            {
                return Ok(response.ToJson());
            }
            else
            {
                return BadRequest(response.Errors.ToString());
            }
        }


        static string NewIdempotencyKey()
        {
            return Guid.NewGuid().ToString();
        }

        static Money NewMoney(int amount, string currency)
        {
            return new Money(amount, Money.CurrencyEnum.USD);
        }
    }
}
