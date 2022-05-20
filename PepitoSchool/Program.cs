using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using PepitoSchool.App.Interfaces;
using PepitoSchool.App.Services;
using PepitoSchool.Domain.Interfaces;
using PepitoSchool.Domain.PepitoSchoolDBEntities;
using PepitoSchool.Forms;
using PepitoSchool.Infraestructura.Repository;
using System;
using System.Windows.Forms;

namespace DepreciationDBApp
{
    static class Program
    {
        public static IConfiguration Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //appsettings daba error por el path asi que lo cree directamente en el PepitoSchool.Form/bin/debug/net5.0-windows
                Configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .AddEnvironmentVariables().Build();
            }
            catch (Exception)
            {
                throw;

            }



            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            services.AddDbContext<PepitoSchoolContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("Default"));
            });
            services.AddScoped<IPepitoSchoolContext, PepitoSchoolContext>();
            services.AddScoped<IEstudianteRepository, EFEstudianteRepository>();
            services.AddScoped<IEstudianteService, EstudianteServices>();
            services.AddScoped<FormPincipoal>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<FormPincipoal>();
                Application.Run(main);
            }

        }
    }
}