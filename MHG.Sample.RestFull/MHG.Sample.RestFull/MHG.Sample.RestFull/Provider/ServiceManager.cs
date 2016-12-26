using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MHG.Sample.RestFull.Provider
{
    public class ServiceManager
    {
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<string> Get()
        {
            var client = GetClient();
            var res = await client.GetStringAsync(new Uri("http://jsonplaceholder.typicode.com/posts/1"));
            return res;
        }

        public async Task<string> Post()
        {
            var client = GetClient();
            var res =
                await
                    client.PostAsync("http://jsonplaceholder.typicode.com/posts",
                        new StringContent("{ 'title': 'murat öner title', 'body': 'murat öner', 'userId': 12 }",
                            Encoding.UTF8, "application/json"));
            return await res.Content.ReadAsStringAsync();
        }
    }
}
