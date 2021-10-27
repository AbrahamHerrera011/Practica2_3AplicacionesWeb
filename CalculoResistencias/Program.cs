/*
Nombre de la escuela: Universidad Tecnológica Metropolitana
Asignatura: Aplicaciones Web Orientadas a servicios
Nombre del maestro: Joel Ivan Chuc Uc
Nombre de la actividad: Actividad 2 - Calcular el valor de una resistencia
Nombre del alumno: Abraham Enrique Herrera Caro
Cuatrimestre: 4
Grupo: C
Parcial: 2
Fecha de entrega: 30/10/2021
*/
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoResistencias
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
