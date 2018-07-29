using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestionDispositivos.Components.Devices;
using Backend;
using Backend.Business.Bussiness.SQL;

namespace gestionDispositivos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            executeScript.runScript(executeScript.configureConnection(), "createDatabase.sql");
            executeScript.runScript(executeScript.configureConnection(), "createTables.sql");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_devices());
            
        }
    }
}
