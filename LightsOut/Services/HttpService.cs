using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using API.Models;

namespace LightsOut
{
    class HttpService
    {

        private readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<Settings> GetSettings(string difficulty)
        {
            Settings setting;
            try
            {
                _httpClient.BaseAddress = new Uri("https://localhost:44377/");
                _httpClient.DefaultRequestHeaders.Accept.Clear();
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string response = await _httpClient.GetStringAsync($"/api/settings/{difficulty}");
                Debug.WriteLine(response);
                setting = JsonSerializer.Deserialize<Settings>(response);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                setting = new()
                {
                    GridSizeX = 5,
                    GridSizeY = 5,
                    Difficulty = "Easy"
                };
            }
            return setting;
        }
    }
}
