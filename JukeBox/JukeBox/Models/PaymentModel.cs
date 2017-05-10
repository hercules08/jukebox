using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JukeBox.Models
{
    public class PaymentModel
    {        
        public int UserId { get; set; }
        public int CreditAmount { get; set; }
        public string Nonce { get; set; }
        //To-Do Leverage Square Customer API to Save Card info
        public string SquareCustomerId { get; set; }
    }
}