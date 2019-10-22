using sprayartsbackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Service.Integration
{
    class GetNet : IGetnet
    {
        public string Payments()
        {
            throw new NotImplementedException();
        }

        public bool VerifyCard(string number_token, string cardholder_name, string expiration_month, string expiration_year, string security_code, string brand = null)
        {
            throw new NotImplementedException();
        }
    }
}
