using System;
using System.Net.Http;
using System.Diagnostics;
using System.Text.Json;
using System.Threading.Tasks;
using API.Models;

namespace LightsOut
{
    class HttpService
    {

        private readonly HttpClient _httpClient;
        private readonly string baseApiUrl = "https://localhost:44377";

        public HttpService(HttpClient httpClient) => _httpClient = httpClient;

        public async Task<Settings> GetSettings()
        {
            Settings setting = new();
            try
            {
                //string response = await _httpClient.GetStringAsync($"{baseApiUrl}/api/settings");
                //setting = JsonSerializer.Deserialize<Settings>(response);
                setting = new()
                {
                    GridSizeX = 5,
                    GridSizeY = 5,
                    Difficulty = "Easy"
                };
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            return setting;
        }
    }
}
