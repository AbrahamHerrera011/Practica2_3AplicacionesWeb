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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoAlcohol.Infraestructura
{
    public class BebidasRepositorio
    {
        //Para que me devuelva los datos a mi controlador declararé un public double ya que quiero obtener un numero en especial
        //ese numero se sacará por medio de formulas que ofrece la practica
        //para los parametros solo necesitare Tipo de bebica, la cantidad que tomó y el peso de la persona
        public double Alcoholimetro(string TipoBebida, double cantidad, double kg)
        {
            //para ir de forma mas ordenada por cada operación yo decidí crear una variable para cada resultado que me fuera arrojando por formula
            double TotalAlcoholConsum;
            double CantAlcoholSangre;
            double MasaEtanolSangre;
            double VolumenSangre;
            double VolumenAlcoholSangre;
            //aqui declaré la variable mililitros ya que es una variable fija que tendrá por bebida, ya luego se ira multiplicando por la cantidad
            //Mismo caso con el Etanol que contiene el tipo de bebida
            double mililitros;
            double etanol;
            //Aquí aplico una validación para que cuando el usuario introduzca un tipo de bebida con mayusculas, la api obligue al texto a volverse todo en minusculas
            //con esto evito errores de validación muy grandes.
            TipoBebida = TipoBebida.ToLower();

            switch (TipoBebida)
            {
                case "cerveza":
                    mililitros = 330 * cantidad;
                    etanol = 5;
                    break;
                case "vino":
                    mililitros = 100 * cantidad;
                    etanol = 12;
                    break;
                case "cava":
                    mililitros = 100 * cantidad;
                    etanol = 12;
                    break;
                case "vermu":
                    mililitros = 70 * cantidad;
                    etanol = 17;
                    break;
                case "licor":
                    mililitros = 45 * cantidad;
                    etanol = 23;
                    break;
                case "brandy":
                    mililitros = 45 * cantidad;
                    etanol = 38;
                    break;
                case "combinado":
                    mililitros = 50 * cantidad;
                    etanol = 38;
                    break;
                   //en en caso de que la bebida introducida no sea correcta, simplemente los valores que van a adquirir nuestras variables serán 0
                default:
                    mililitros = 0;
                    etanol = 0;
                    break;
            }
            //formula para calcular el total de alcohol consumido
            TotalAlcoholConsum = (etanol * 0.010) * mililitros;
            //formula para calcular la cantidad de alcohol que pasa directo a la sangre
            CantAlcoholSangre = 0.15 * TotalAlcoholConsum;
            //formula para calcular la masa del etanol en sangre 
            MasaEtanolSangre = 0.789 * CantAlcoholSangre;
            //formula para calcular el volumen de la sangre de la persona considerando su peso
            VolumenSangre = 0.08 * kg;
            //formula para calcular el volumen de alcohol en la sangre(Alcoholemia)
            VolumenAlcoholSangre = MasaEtanolSangre / VolumenSangre;
            return VolumenAlcoholSangre;


        }
    }
}
