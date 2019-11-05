using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace sprayartsbackend.Integration.Service
{
    internal class GetnetService : IDisposable
    {
        protected const string client_id = "cc9fe08c-21ae-4a64-96cf-857d29cc2295";
        protected const string client_secret = "f3cb461e-806b-4f63-9677-eeba5a456c80";
        protected const string urlApiGetnetBase = "https://api-sandbox.getnet.com.br/";
        private HttpClient client;

        private string authBase64 = null;

        private string Token_Auth { get; set ; }

        public GetnetService()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri(urlApiGetnetBase);

                authBase64 = Base64Encode(string.Concat(client_id, ":", client_secret));
            }
        }

        public void GetAuth()
        {
            try
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0");
                client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR,pt;q=0.8,en-US;q=0.5,en;q=0.3");
                //client.DefaultRequestHeaders.Add("Authorization", "Basic Y2M5ZmUwOGMtMjFhZS00YTY0LTk2Y2YtODU3ZDI5Y2MyMjk1OmYzY2I0NjFlLTgwNmItNGY2My05Njc3LWVlYmE1YTQ1NmM4MA==");
                client.DefaultRequestHeaders.Add("Authorization", string.Concat("Basic ", authBase64));
                client.DefaultRequestHeaders.Add("Referer", "https://developers.getnet.com.br/dashboard");
            

                string url = string.Concat(urlApiGetnetBase, "auth/oauth/v2/token");
                
                HttpResponseMessage respToken = client.PostAsync(url, new StringContent("scope=oob&grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded")).Result;

                Token_Auth = string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetToken()
        {
            var token = string.Empty;

            GetAuth();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:69.0) Gecko/20100101 Firefox/69.0");
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR,pt;q=0.8,en-US;q=0.5,en;q=0.3");
            client.DefaultRequestHeaders.Add("Authorization", "Basic Y2M5ZmUwOGMtMjFhZS00YTY0LTk2Y2YtODU3ZDI5Y2MyMjk1OmYzY2I0NjFlLTgwNmItNGY2My05Njc3LWVlYmE1YTQ1NmM4MA==");
            client.DefaultRequestHeaders.Add("Referer", "https://developers.getnet.com.br/dashboard");

            string url = string.Concat(urlApiGetnetBase, "v1/tokens/card");

            HttpResponseMessage respToken = client.PostAsync(url, new StringContent("{'card_number':'5155901222280001'}", Encoding.UTF8, "application/json")).Result;

            return token;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public void Dispose()
    {
        this.Dispose();
        GC.Collect();
    }
}
}
