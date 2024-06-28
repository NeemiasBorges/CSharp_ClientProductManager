using Aplicacao.Interface;
using Aplicacao.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace FormView
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                var loggerConfig = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day);

                var seqUrl = ConfigurationManager.AppSettings["Serilog:SeqUrl"];
                if (!string.IsNullOrEmpty(seqUrl))
                {
                    loggerConfig = loggerConfig.WriteTo.Seq(seqUrl);
                }

                Log.Logger = loggerConfig.CreateLogger();
                AppLogger.Logger = Log.Logger;

                AppLogger.Logger.Information("========== INICIANDO SISTEMA ==========");

                var serviceCollection = new ServiceCollection();
                ConfigureServices(serviceCollection);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new App());
            }
            catch (Exception e)
            {
                AppLogger.Logger.Error(e, "Um erro ocorreu durante a execução do aplicativo.");
            }
            finally
            {
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IClienteInterface, ClienteService>();
            services.AddSingleton<IContatoInterface, ContatoService>();
            services.AddSingleton<IEnderecoInterface, EnderecoService>();
            services.AddSingleton<IProdutoInterface, ProdutoService>();
            services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
        }
    }
}
