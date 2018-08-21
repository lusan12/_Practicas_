using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Jugador : Persona
    {
        protected string club;

        public string Club


        {
            set
            {
                club = value;
            }
            get
            {
                return club;
            }
        }
        protected string posicion;

        public string Posicion


        {
            set
            {
                posicion = value;
            }
            get
            {
                return posicion;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Club:" + Club);
            Console.WriteLine("Posicion:" + Posicion);
        }
    }
}
