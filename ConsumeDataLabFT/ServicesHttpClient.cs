using Inexa.DependencyContainer.AutoRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT
{
    [Implement(typeof(IServiceSingletonHttpClient))]
    public sealed class ServicesHttpClient : IServiceSingletonHttpClient
    {
        private readonly HttpClient client;
        readonly string _BaseAddress;
        private static ServicesHttpClient _Instance = null;
        private static readonly Object _Verrou = new object();

        public static ServicesHttpClient GetInstance
        {
            get
            {

                if (_Instance == null)
                {
                    lock (_Verrou)
                    {
                        if (_Instance == null)
                        {
                            _Instance = new ServicesHttpClient();
                        }
                    }
                }

                return _Instance;
            }
        }


        private ServicesHttpClient()
        {

            _BaseAddress = "https://bridgerstaging.lexisnexis.com/LN.WebServices";//ConfigurationServiceUse.getServiceParameters().BaseAdresse();
            client = new HttpClient();
            client.BaseAddress = new Uri(_BaseAddress);
        }

        /// <summary>
        /// 
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé: 
        ///         Htppt avec base adresse asigne
        ///     
        /// </summary>
        /// <returns>HttpClient</returns>
        public HttpClient ServicesHttpClientBaseAddress()
        {
            return client;
        }
    }
}