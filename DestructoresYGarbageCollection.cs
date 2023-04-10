using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class DestructoresYGarbageCollection
    {
        public DestructoresYGarbageCollection()
        {
            //constructor
        }
        ~DestructoresYGarbageCollection()
        {
            //esto es un destructor
            //se usan solo en tipos de referencia, no en tipos de valor
            //No tienen modificador de acceso
            //No reciben parámetros porque no se llaman manualmente
            //El compilador transforma este método en una sobreescriture del métodod Objecr.Finalize
            //Nunca sabes cuándo correrá este destructor       
        }
        //también hablaba del finally
        /* Dice que:
            -queda la cagá si se debe añgo de unos recursos
            -a veces debes modificar el código para que encaje o algo así
            -Falla a la hora de crear una abstracción de la solución, o sea que es difícil de entender
            -La referencia del recurso permanece en scope después del bloque finally, lo que quiere decir
             que accidentalmente puedes tratar de usar el recurso después o algo así
        */

        //Y ahora viene la parte de los using

        //Me salté todo eso porque tengo la mente en otra por la FFFFFFF 
    }
}
