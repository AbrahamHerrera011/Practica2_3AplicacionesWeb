/*
Nombre de la escuela: Universidad Tecnológica Metropolitana
Asignatura: Aplicaciones Web Orientadas a servicios
Nombre del maestro: Joel Ivan Chuc Uc
Nombre de la actividad: Actividad 2 - Calcular el nivel de alcohol en la sangre(alcoholemia)
Nombre del alumno: Abraham Enrique Herrera Caro
Cuatrimestre: 4
Grupo: C
Parcial: 2
Fecha de entrega: 30/10/2021
*/
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculoAlcohol.Infraestructura;

namespace CalculoAlcohol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholemiaController : ControllerBase
    {
       [HttpGet]
       [Route("{Tipobebida}/{cantidad}/{kg}")]
       //ahora voy a devolver una cadena de texto a la Api como respuesta, recibiré los parametros: Tipo de bebida, cantidad y peso de la persona en kg
       public string Alcoholemia(string TipoBebida, double cantidad, double kg)
        {
            double ResulAlcoholemia;
            var repositorio = new BebidasRepositorio();
            ResulAlcoholemia = repositorio.Alcoholimetro(TipoBebida, cantidad, kg);
            //aprovechó aquí a hacer una condicional if para poder saber si una persona es apta o no para manejar, mi valor de referencia es 0.8
            // si es mayor a 0.8 g/L entonces la persona no es apta para manejar
            if(ResulAlcoholemia <= 0.8)
            {
                return Convert.ToString("El resultado de su test de Alcoholemia es: " + Math.Round(ResulAlcoholemia, 3)+"g/L" + " Le deseamos muy buen viaje");
            }
            else
            {
                return Convert.ToString("El resultado de su test de Alcoholemia es: " + Math.Round(ResulAlcoholemia, 3) + "g/L" + " Solicitar apoyo para el conductor");
            }
        }
    }
}
