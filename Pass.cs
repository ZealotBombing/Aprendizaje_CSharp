using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Pass//ejercicio del libro para usar parámetros de valor y de referencia
    {
        public static void Value(int param)
        {
            param = 42;
        }
        public static void Reference(Wrapped param)//parámetro de referencia
        {
            param.Number = 42;//Number es el campo de la clase Wrapped
        }
    }
}
