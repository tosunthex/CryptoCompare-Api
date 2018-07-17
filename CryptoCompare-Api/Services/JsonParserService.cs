using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CryptoCompare_Api.Services
{
    public class JsonParserService
    {
        public async Task<T> ParseResponse<T>(HttpResponseMessage httpResponseMessage)
        {
            httpResponseMessage.EnsureSuccessStatusCode();
            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            try
            {
                return JsonConvert.DeserializeObject<T>(responseContent);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}