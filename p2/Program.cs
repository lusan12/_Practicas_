using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{   

    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Practica II - Tecnicas de Programacion**");
            Jugador Jugador1 = new Jugador();
            Jugador1.Nombre = "Paulo Dybala";
            Jugador1.Edad = 24;
            Jugador1.Nacionalidad = "Argentino";
            Jugador1.Posicion = "Delantero";
            Jugador1.Club = "Juventus";
            Console.WriteLine("El Jugador es:");
            Jugador1.Imprimir();

            Console.ReadKey();
        }
    }
}