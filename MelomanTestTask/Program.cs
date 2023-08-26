using MelomanTestTask.Domain;
using MelomanTestTask.Domain.Services;
using MelomanTestTask.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace MelomanTestTask
{
  internal static class Program
  {
    public static IServiceProvider ServiceProvider { get; set; }

    /// <summary>
    /// Registers dependencies to use Dependency Injection pattern.
    /// </summary>
    static void ConfigureServices()
    {
      var services = new ServiceCollection();
      services
        .AddSingleton<MSSQLContext>()
        .AddSingleton<IRepository, MSSQLRepository>()
        .AddSingleton<CompanyService>()
        .AddSingleton<EmployeeService>();
      ServiceProvider = services.BuildServiceProvider();
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      ConfigureServices();
      Application.Run(new MainForm());
    }
  }
}
