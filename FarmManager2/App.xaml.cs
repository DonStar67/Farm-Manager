using FarmManager2.Models;
using FarmManager2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // Для ServiceCollection и BuildServiceProvider
using System;
using System.Configuration;
using System.Data;
using System.Security.Principal;
using System.Windows; // Уже есть, для Application и OnStartup
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace FarmManager2
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(DataBase.ConnectionString));

            // Пока оставим закомментированными — включим на следующих шагах
            // services.AddScoped<IAccountRepository, AccountRepository>();
            // services.AddScoped<IAuthenticationService, AuthenticationService>();

            ServiceProvider = services.BuildServiceProvider();
        }
    } 
}
