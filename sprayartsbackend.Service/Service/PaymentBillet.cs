using sprayartsbackend.Domain.Model;
using sprayartsbackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Service
{
    public class PaymentBillet : IPayment
    {
        private readonly Billet _billet;

        public PaymentBillet(Billet billet)
        {
            _billet = billet;
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }
    }
}
