using Serilog;
using System.Configuration;

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

            var seqUrl           = ConfigurationManager.AppSettings["Serilog:SeqUrl"];
            if (!String.IsNullOrEmpty(seqUrl))
                Log.Logger           = new LoggerConfiguration().WriteTo.Seq(seqUrl).CreateLogger();

            ApplicationConfiguration.Initialize();
            Application.Run(new App());
        }
    }
}