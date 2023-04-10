using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    static class ClaseDePrueba1 //no se pueden hacer instancias de esta clase.
                                ////Las clases estáticas son contenedores de funciones y campos
    {
        //CLR: common language runtime
        //Encapsulación
        //atributos y métodos son privados por defecto
        //privado significa que actua a nivel de la clase, incluyendo sus objetos.

        public static void declararClaseAnomina()
        {
            var objeto = new { nombre = "Fernada", edad = 24 };//clase anónima 
        }
    }
}
