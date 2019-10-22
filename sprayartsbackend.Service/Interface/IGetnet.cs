using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Service.Interface
{
    public interface IGetnet
    {
        bool VerifyCard(string number_token, string cardholder_name, string expiration_month, string expiration_year, string security_code, string brand = null);
        string Payments();

    }
}
