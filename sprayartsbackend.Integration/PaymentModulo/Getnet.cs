using sprayartsbackend.Integration.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Integration.PaymentModulo
{
    public class Getnet
    {
        public Getnet()
        {

        }

        public string Tokenizacao()
        {
            using(GetnetService getnet = new GetnetService())
            {
                return getnet.GetToken();
            }
        }
    }
}
