using ConsumeDataLabFT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Services
{
    public class TokenService
    {
        private readonly HttpClient _client;
        private readonly ServicesHttpClient _services;
        private readonly ServicesHttpClient servicesHttpClient;
        public TokenService()
        {
            servicesHttpClient = ServicesHttpClient.GetInstance;
            _client = _services.ServicesHttpClientBaseAddress();
        }

        public async Task<OAuth2Token> GetToken(string clientId, string clientSecret)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            //_client.DefaultRequestHeaders.Add();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            // _client.DefaultRequestHeaders.Add("apikey", apikey);
            _client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(
                     System.Text.ASCIIEncoding.ASCII.GetBytes(
                        $"{clientId}:{clientSecret}")));

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, _client.BaseAddress);
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();

            postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            postData.Add(new KeyValuePair<string, string>("scope", "public"));

            request.Content = new FormUrlEncodedContent(postData);

            var response = await _client.PostAsync(ConstantEndPoint.TokenUrl, new FormUrlEncodedContent(postData));

            var content = await response.Content.ReadAsStringAsync();

            return null;
        }

    }
}
