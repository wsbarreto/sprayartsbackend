using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace sprayartsbackend.Integration.Base
{
    public class BaseApi
    {
        private HttpClient _client;

        public virtual void LoadHeader()
        {
            _client.DefaultRequestHeaders.Clear();

        }
    }
}
