using Microsoft.VisualStudio.TestTools.UnitTesting;
using sprayartsbackend.Integration.PaymentModulo;

namespace UnitTestProject1
{
    [TestClass]
    public class TokenTest
    {
        [TestMethod]
        public void Tokenizacao()
        {
            Getnet obj = new Getnet();
            var result = obj.Tokenizacao();
        }
    }
}
