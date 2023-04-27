using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Services
{
    public class TokenService
    {
        private readonly ServicesHttpClient servicesHttpClient;
        public TokenService()
        {
            servicesHttpClient = ServicesHttpClient.GetInstance;
        }

        public string GetToken()
        {
            servicesHttpClient.ServicesHttpClientBaseAddress
        }
    }
}
