using Serilog;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace FormView
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            try
            {
                var seqUrl = ConfigurationManager.AppSettings["Serilog:SeqUrl"];
                if (!String.IsNullOrEmpty(seqUrl))
                    Log.Logger = new LoggerConfiguration().WriteTo.Seq(seqUrl).CreateLogger();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new App());
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}