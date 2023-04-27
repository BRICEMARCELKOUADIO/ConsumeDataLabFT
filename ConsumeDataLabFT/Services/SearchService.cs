using ConsumeDataLabFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT.Services
{
    public class SearchService : IProviderWebService
    {
        public Task<bool> DeleteAsync<T>(string Url)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>(string Url)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostAsync<T>(string Url, T t)
        {
            throw new NotImplementedException();
        }

        public Task<R> PostAsyncComplex<R, T>(string Url, T t)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutAsyn<T>(string Url, T t)
        {
            throw new NotImplementedException();
        }
    }
}
