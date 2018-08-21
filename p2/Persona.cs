using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica2
{
    public class Persona
    {
        protected string nombre;
        protected int edad;
        protected string nacionalidad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public string Nacionalidad
        {
            set
            {
                nacionalidad = value;
            }
            get
            {
                return nacionalidad;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + Nombre);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Nacionalidad:" + Nacionalidad);
        }
    }
}