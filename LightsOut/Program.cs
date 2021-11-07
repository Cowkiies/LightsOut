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
            Settings setting = httpService.GetSettings().Result;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LightsOut(setting.GridSizeX, setting.GridSizeY));
        }
    }
}
