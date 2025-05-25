using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjercicioClase2.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EjercicioClase2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myCat = new Cat() { Id = 1, Name = "Gato" };
            Console.WriteLine("Id del gato: " + myCat.Id);
            Console.WriteLine("Nombre del gato: " + myCat.Name);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
