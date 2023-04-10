using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Binarius
    {
        public static void NotBinario()
        {
            Console.WriteLine(~204);
        }
        public static void ShiftOperador()
        {
            Console.WriteLine(204);
            Console.WriteLine(204>>2);
        }
        public static void OrBinario()
        {
            Console.WriteLine(204 | 24);//pone un 1 donde uno tiene 1 y el otro no (creo)
        }
        public static void AndBinario()
        {
            Console.WriteLine(204 & 24);//retorna 1 donde los dos tienen un 1, los demás son 0s
        }
        public static void XorBinario()
        {
            Console.WriteLine(204 ^ 24);//retorna 1 donde uno tiene 1 y el otro no
        }
    }
}
