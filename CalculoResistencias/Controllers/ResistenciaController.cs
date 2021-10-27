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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculoResistencias.Infraestructura;

namespace CalculoResistencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        public string ResistenciaFinal(string tirita1, string tirita2, string multiplicador, string tolerancia)
        {
            string ResulFinal;
            var repositorio = new resistenciaRepositorio();
            ResulFinal = repositorio.Resistencia(tirita1, tirita2, multiplicador, tolerancia);
            return ResulFinal;
        }
    }
}
