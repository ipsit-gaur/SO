using System;
using System.Configuration;

namespace SO.Client.Base
{
    internal class AuthClient
    {
        internal string GetFreshBearerToken()
        {
# if DEBUG
            return ConfigurationManager.AppSettings["Dev_AccessToken"];
#else
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["StackExchangeAPI_Url"]);
                var nvc = new List<KeyValuePair<string, string>>();
                nvc.Add(new KeyValuePair<string, string>("client_id", ConfigurationManager.AppSettings["StackExchangeApp_ClientID"]));
                nvc.Add(new KeyValuePair<string, string>("client_secret", ConfigurationManager.AppSettings["StackExchangeApp_ClientSecretKey"]));
                nvc.Add(new KeyValuePair<string, string>("code", ConfigurationManager.AppSettings["StackExchangeApp_ClientCode"]));
                nvc.Add(new KeyValuePair<string, string>("redirect_uri", ConfigurationManager.AppSettings["StackExchangeApp_OAuthRedirectUrl"]));

                var response = client.PostAsync("access_token", new FormUrlEncodedContent(nvc)).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("API didnt go well");
                }

                var data = response.Content.ReadAsStringAsync().Result;
            }
            return null;
# endif
        }
    }

    internal class BearerToken
    {
        internal string Token { get; set; }
        internal DateTime ExpiryTime { get; set; }
    }
}
