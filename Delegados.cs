using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Delegados
    {
        delegate string HacerDelegado();
    }
    class MensajeBienvenida
    {
        public static void SaludoBienvenida()
        {
            Console.WriteLine("Hola, acabo de llegar ¿Qué tal?");
        }
        public static void Saludar(string msj)
        {
            Console.WriteLine("Hola, acabo de llegar ¿Qué tal? {0}",msj);
        }
    }
    class MensajeDespedida
    {
        public static void SaludoDespedida()
        {
            Console.WriteLine("Chao, me voy");
        }
        public static void Despedir(string msj)
        {
            Console.WriteLine("Chao, me voy {0}",msj);
        }
    }
}
