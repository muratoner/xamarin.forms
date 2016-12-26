using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MHG.Sample.Social.Provider
{
    public class ServiceManager<T> where T : class 
    {
        HttpClient GetClient()
        {
            return new HttpClient();
        }

        public async Task<T> Get(string uri)
        {
            var httpClient = GetClient();
            return JsonConvert.DeserializeObject<T>(await httpClient.GetStringAsync(uri));
        } 

        public async Task<T> GetFacebookProfile(string accessToken)
        {
            var url = $"https://graph.facebook.com/v2.8/me?access_token={accessToken}&debug=all&fields=id%2Cname%2Cbirthday%2Ceducation%2Cabout%2Ccover%2Cphotos%2Cpicture&format=json&method=get&pretty=0&suppress_http_code=1";

            var client = GetClient();
            var res = await client.GetStringAsync(url);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(res);
        }
    }
}
