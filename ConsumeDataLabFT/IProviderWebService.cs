using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeDataLabFT
{
    public interface IProviderWebService
    {
        Task<bool> DeleteAsync<T>(string Url);
        Task<T> GetAsync<T>(string Url);
        Task<bool> PostAsync<T>(string Url, T t);
        Task<bool> PutAsyn<T>(string Url, T t);
        Task<R> PostAsyncComplex<R, T>(string Url, T t);
    }
}
