using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightsOut
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        //TODO 
        // Build DB with indempotent scripts - settings table only ? get functions ?
        // Fill DB with data via scripts
        // Create REST API with endpoints for :
        //   Get grid size via API -> DB
        //   Get initial grid state API 5x5 with values [0, 1] - 3 diffculty settings GET /initGrid/{difficulty} - [0, 2]
        //       ( EZPZ: 5 initialised lights // PEASANT: 10? lights on // TRUEMAN: 15? lights on) - Or change how they are scattered ?
        //   Get grid size via API -> DB
        // ----
        // If saved state confirmDialog `load ?`
        // Init FormGrid ([][]) with settings
        // Grid UI
        // Game Loop while !winCon and !escKeyPressed:
        //   onClick get coordinates and change state of clicked + adjacent case
        //   If everything == 0 winCon
        // end loop
        // Dialog for win
        // confirmDialog with escKeyPressed asking for save ?

        // 


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
