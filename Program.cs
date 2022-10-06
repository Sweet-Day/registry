using BLL.Modules;
using Registry.Forms;
using Registry.Forms.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(CompositionRoot.Resolve<MainForm>());
        }
    }
}
