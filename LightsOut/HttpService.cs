using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace LightsOut
{
    class HttpService
    {

        private readonly HttpClient _httpClient;
        private readonly string baseApiUrl = "http://localhost:51616";

        public HttpService(HttpClient httpClient) => _httpClient = httpClient;

        public async void GetSettings(string setting)
        {
            try
            {
                string result = await _httpClient.GetStringAsync($"{baseApiUrl}/InitGrid/easy");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
