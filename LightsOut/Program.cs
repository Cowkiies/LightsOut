using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Diagnostics;
using API.Models;

namespace LightsOut
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            HttpClient client = new();
            HttpService httpService = new(client);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DifficultyPicker DifficultyPicker = new();
            Application.Run(DifficultyPicker);

            Settings setting = httpService.GetSettings(DifficultyPicker.chosenDifficulty).Result;

            Application.Run(new LightsOut(setting.GridSizeX, setting.GridSizeY));
        }
    }
}
