using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SO.Client.Base
{
    public abstract class BaseClient
    {
        protected async Task<T> GetResponse<T, D>(string endpoint, HttpMethod method, D content, bool enableAuth)
        {
            string token = null;
            if (enableAuth)
                token = (new AuthClient().GetFreshBearerToken());

            using (var client = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["StackExchangeAPI_Url"]);
                if (enableAuth)
                {
                    client.DefaultRequestHeaders.Add("X-API-Access-Token", token);
                    client.DefaultRequestHeaders.Add("X-API-Key", ConfigurationManager.AppSettings["StackExchangeAPI_Key"]);
                }
                var response = await client.GetAsync(endpoint);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("API threw an error!");
                }

                var data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(data);
            }
        }
    }
}
