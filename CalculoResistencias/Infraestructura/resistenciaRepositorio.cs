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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoResistencias.Infraestructura
{
    public class resistenciaRepositorio
    {
        //Decidí devolver un string por lo requerido en la práctica, no apliqué una capa de dominio ya que, no va a devolver una lista de cosas
        public string Resistencia(string Primer_Tira,string Segunda_Tira, string Multiplicador, string Tolerancia)
        {
            //vamos a declarar variables para los resultados finales, en este caso necesito saber la cantidad de ohmios de la resistencia
            //y también necesito saber cuanto es la tolerancia que tendrá la resistencia de acuerdo a lo introducido por el usuario
            double ohmios;
            string toleranciaResul;
            //hacemos una pequeña validación para que cuando el usuario ingrese un dato, este automaticamente  cambie todas sus letras a minuscula
            Primer_Tira = Primer_Tira.ToLower();
            Segunda_Tira = Segunda_Tira.ToLower();
            Multiplicador = Multiplicador.ToLower();
            Tolerancia = Tolerancia.ToLower();
            //cuando utilizemos el switch esto nos será de mucha ayuda ya que unicamente tendremos que poner un solo resultado que coincida con la cadena de texto que introduzca el usuario
            //por ejemplo si pone Negro,NEGRO,NeGrO al utilizar ToLower(); esto hará que sea igual a negro. Todo esto para evitar problemas

            //utilizaré una instrucción de selección o en pocas palabras una estructura switch para poder elegir mis opciones
            //y no llenar el codigo de puro if else, if else, etc...
            switch (Primer_Tira)
            {
                //en este caso al ser la primera Tira de la resistencia, por cada valor que me indica la tabla de la práctica lo convertiré en decena
                //al hacer esto, cuando haga el proximo switch solamente tendré que sumarle la segunda tira, lo que nos facilitará el trabajo.
                case "negro":
                    ohmios = 0;
                    break;
                case "cafe":
                    ohmios = 10;
                    break;
                case "rojo":
                    ohmios = 20;
                    break;
                case "naranja":
                    ohmios = 30;
                    break;
                case "amarillo":
                    ohmios = 40;
                    break;
                case "verde":
                    ohmios = 50;
                    break;
                case "azul":
                    ohmios = 60;
                    break;
                case "violeta":
                    ohmios = 70;
                    break;
                case "gris":
                    ohmios = 80;
                    break;
                case "blanco":
                    ohmios = 90;
                    break;
                //la práctica pide que le mostremos al usuario un error si es que introduce un color incorrecto y en donde se encuentra su error
                //asi que como ya introducimos todos los colores posibles, lo unico que podrá poner diferente son cosas incorrectas.
                default:
                    return "Ingrese un color valido por favor, ERROR EN LA PRIMERA TIRA";
            }
            //vamos por la segunda tira, como es por estructuras switch cabe aclarar que la API al recorrer el codigo, lo hará utilizando una misma variable
            //No hay necesidad de crear otra variable ya que esta ira cambiando con el tiempo y adquiriendo un nuevo valor cada vez que le asignemos algo nuevo.
            switch (Segunda_Tira)
            {
                //aplicamos lo antes mencionado
                case "negro":
                    ohmios = ohmios+0;
                    break;
                case "cafe":
                    ohmios = ohmios+1;
                    break;
                case "rojo":
                    ohmios = ohmios+2;
                    break;
                case "naranja":
                    ohmios = ohmios+3;
                    break;
                case "amarillo":
                    ohmios = ohmios+4;
                    break;
                case "verde":
                    ohmios = ohmios+5;
                    break;
                case "azul":
                    ohmios = ohmios+6;
                    break;
                case "violeta":
                    ohmios = ohmios+7;
                    break;
                case "gris":
                    ohmios = ohmios+8;
                    break;
                case "blanco":
                    ohmios = ohmios+9;
                    break;
                //lo mismo que en el caso anterior solo marcando que el error se encuentra en esta tirita
                default:
                    return "Ingrese un color valido por favor, ERROR EN LA SEGUNDA TIRA";
            }
            //vamonos al multiplicador
            switch (Multiplicador)
            {
                //En este caso no puse los colores violeta, gris y blanco ya que la práctica menciona que son colores que son prácticamente imposibles de utilizar
                //esto es por su gran valor que aportan al resultado, lo que ofrece un valor de resistencia muy alto
                case "negro":
                    ohmios = ohmios*1;
                    break;
                case "cafe":
                    ohmios = ohmios*10;
                    break;
                case "rojo":
                    ohmios = ohmios * 100;
                    break;
                case "naranja":
                    ohmios = ohmios*1000;
                    break;
                case "amarillo":
                    ohmios = ohmios*10000;
                    break;
                case "verde":
                    ohmios = ohmios*100000;
                    break;
                case "azul":
                    ohmios = ohmios*1000000;
                    break;
                //apartado especial aquí, según la tabla, aquí empieza a dividirse. 
                //solamente dividiremos entre 10 en dorado y entre 100 a plata, para recorrer los 0
                case "dorado":
                    ohmios = ohmios/10;
                    break;
                case "plata":
                    ohmios = ohmios/100;
                    break;
                //su respectivo error en caso de que no ponga un color correcto
                default:
                    return "Ingrese un color valido por favor, ERROR EN EL MULTIPLICADOR";
            }
            switch (Tolerancia)
            {
                //aqui no necesitamos hacer ningún calculo, los unicos valores aceptados según la práctica son dorado y plata
                //asi que esos colores son los unicos que utilizaré con sus respectivas tolerancias
                case "dorado":
                    toleranciaResul = "5%";
                    break;
                case "plata":
                    toleranciaResul = "10%";
                    break;
                //hacemos sus respectiva validación en caso de que ponga otro color
                default:
                    return "Ingrese un color valido por favor, ERROR EN LA TOLERANCIA";
            }
            //aquí ya simplemente, mostramos con un return el resultado de lo antes calculado
            return "El total de ohmios de esta resistencia es: " + ohmios + " y la tolerancia que tendrá es +-: " + toleranciaResul;

        }



    }
}
