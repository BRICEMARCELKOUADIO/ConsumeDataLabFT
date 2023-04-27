using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Inexa.DependencyContainer.AutoRegister;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ConsumeDataLabFT
{
    [Implement(typeof(IProviderWebService))]
    public class GenericProviderWebService : IProviderWebService
    {
        private readonly ServicesHttpClient _services;
        private readonly HttpClient _client;
        //private readonly ICrmException _crmException;

        public GenericProviderWebService()
        {
            //_crmException = exception;
            _services = ServicesHttpClient.GetInstance;
            _client = _services.ServicesHttpClientBaseAddress();
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            ServicePointManager.FindServicePoint(new Uri(ConfigurationServiceUse.getServiceParameters().BaseAdresse()));
        }



        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///         DeleteAsync<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Url"></param>
        /// <returns></returns>

        public async Task<bool> DeleteAsync<T>(string Url)
        {
            HttpResponseMessage response = await _client.DeleteAsync(Url);

            if (!response.IsSuccessStatusCode) await throwErrorMessageResponse<T>(response,null);

            return true;
        }


        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///         GetAsync<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Url"></param>
        /// <returns></returns>

        public async Task<T> GetAsync<T>(string Url)
        {
            T data;

            HttpResponseMessage response = await _client.GetAsync(Url);

            string Result = "";

            if (!response.IsSuccessStatusCode) await throwErrorMessageResponse<T>(response,null);

            Result = await response.Content.ReadAsStringAsync();

            data = await Task.Run(() => JsonConvert.DeserializeObject<T>(Result));

            return await Task.FromResult<T>(data);
        }


        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///         PostAsync<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Url"></param>
        /// <param name="contentPost"></param>
        /// <returns></returns>

        public async Task<bool> PostAsync<T>(string Url, T t)
        {
            var HTTPMsg = requestDejaSerialiSerJson<T>(t);

            HttpResponseMessage Response = await _client.PostAsync(Url, HTTPMsg.Content);

            if (!Response.IsSuccessStatusCode) await throwErrorMessageResponse<T>(Response,null);

            return true;
        }

        private Task throwErrorMessageResponse<T>(HttpResponseMessage response, object p)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///          PutAsyn<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Url"></param>
        /// <param name="contentPut"></param>
        /// <returns></returns>

        public async Task<bool> PutAsyn<T>(string Url, T t)
        {
            var HTTPMsg = requestDejaSerialiSerJson<T>(t);

            HTTPMsg.Method = HttpMethod.Put;

            HttpResponseMessage Response = await _client.PutAsync(Url, HTTPMsg.Content);

            if (!Response.IsSuccessStatusCode) await throwErrorMessageResponse<T>(Response,null);

            return true;
        }

        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     resumé:
        ///         Methode private generic qui serialize l'entite et retourne un HttpRequestMessqge
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>

        static HttpRequestMessage requestDejaSerialiSerJson<T>(T t)
        {
            string jsonDataT = JsonConvert.SerializeObject(t, Formatting.Indented, new JsonSerializerSettings() { ContractResolver = new CamelCasePropertyNamesContractResolver(), Converters = new List<JsonConverter>() { new StringEnumConverter() } });

            var httpRequestMessage = new HttpRequestMessage
            {
                Content = new StringContent(jsonDataT, Encoding.UTF8, "application/json")
            };

            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return httpRequestMessage;
        }


        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///         Methode private d'error pour put et post avec nom de l'entite et le message d'erreur
        /// </summary>
        /// <remarks>
        ///     Loggue des exceotion en base au lien de les throw permet de rendre l'application bloqaunte
        /// </remarks>
        /// <typeparam name="T"></typeparam>
        /// <param name="Response"></param>
        /// <returns></returns>
        //async Task throwErrorMessageResponse<T>(HttpResponseMessage Response, ExceptionCrmDto exceptionCrmDto)
        //{
        //    string Result = null;

        //    Result = await Response.Content.ReadAsStringAsync();

        //    string entite = typeof(T).Name;

        //    exceptionCrmDto.Libelle = Result;

        //    exceptionCrmDto.Source = entite;

        //    _crmException.Create(exceptionCrmDto).Wait();
        //}


        /// <summary>
        ///     
        ///     Auteur: Kra Kobenan Olivier
        ///     
        ///     Resumé:
        ///        Methode de post avec return complexe
        /// </summary>
        /// <typeparam name="R">Entite de retour</typeparam>
        /// <typeparam name="T">Entite d'envoie</typeparam>
        /// <param name="Url"></param>
        /// <param name="t"></param>
        /// <returns></returns>

        public async Task<R> PostAsyncComplex<R, T>(string Url, T t)
        {
            R data;

            var HTTPMsg = requestDejaSerialiSerJson<T>(t);

            HTTPMsg.Method = HttpMethod.Post;

            var Response = _client.PostAsync(Url, HTTPMsg.Content).Result;

            if (!Response.IsSuccessStatusCode) await throwErrorMessageResponse<T>(Response,null);

            var Result = Response.Content.ReadAsStringAsync().Result;

            data = JsonConvert.DeserializeObject<R>(Result);

            return data;
        }
    }
}