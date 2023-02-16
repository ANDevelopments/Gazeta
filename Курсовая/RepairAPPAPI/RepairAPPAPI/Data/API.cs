using System;
using System.Net.Http.Headers;
using System.Net.Http;

namespace RepairAPPAPI.Data
{
    public class API
    {
        public string BaseUri => "http://localhost:5176";
        public HttpClient HttpClient { get; }

        public API()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(BaseUri);
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
