﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Microsoft.Extensions.DependencyInjection;
using PepitoSchool.App.Interfaces;
using PepitoSchool.App.Services;
using PepitoSchool.Domain.Interfaces;
using PepitoSchool.Domain.PepitoSchoolDBEntities;
using PepitoSchool.Forms.Forms;
using PepitoSchool.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepitoSchool
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
            services.AddScoped<IEstudiantesServices, EstudianteServices>();
            services.AddScoped<Principal>();

            using (var serviceScope = services.BuildServiceProvider())
            {
                var main = serviceScope.GetRequiredService<Principal>();
                Application.Run(main);
            }

        }
    }
}