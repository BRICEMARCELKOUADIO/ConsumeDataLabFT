using ConsumeDataLabFT.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var tokenService = new TokenService();
            var token = await tokenService.GetToken("KyriaConSvsCITest/BMarcel30", "@Wormkernel1");
            Console.WriteLine("Token = "+token?.access_token);
            Console.ReadLine();
        }
    }
}
