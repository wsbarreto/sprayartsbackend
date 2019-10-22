using sprayartsbackend.Domain.Model;
using sprayartsbackend.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Service
{
    public class PaymentCard : IPayment
    {
        private readonly Card _card;

        public PaymentCard(Card card)
        {
            _card = card;
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }
    }
}
