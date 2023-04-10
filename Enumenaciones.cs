using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    enum Estaciones { Otoño, Invierno, Primavera, Verano }//Declarar un enum
    //por defecto emperazá en 0, pero se puede asociar un número manualmente
    enum PuntosCardinales {Norte=1, Sur=2, Este=3, Oeste=4 }
    enum TortugasNinja { Leonardo=1,MiguelAngel, Donatello, Rafael}//los literales ahora son por defecto 1, 2, 3 y 4
    enum Frituras { Sopaipilla, TortaFrita=Sopaipilla, papasFritas, crispy}//TortaFrita es Sopaipilla

    enum Season : short {Summer, Fall, Winter, Spring}//se puede usar cualquier tipo de dato de números enteros
    //el tipo short ayuda a salvar memoria
    enum Points : long { north, south, east, west}

    enum Mes {Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }
    class Enumenaciones
    {
       public static void usarEnum()
       {
            Estaciones estaciones = Estaciones.Otoño;//asignar enum
            Console.WriteLine(estaciones);

            //también es nullable
            Estaciones? estaciones1 = null;

            //se puede convertir a string
            string nombre = estaciones.ToString();
       }
        public static void operarEnum()
        {
            Estaciones estacion = Estaciones.Invierno;
            Estaciones estacion1 = Estaciones.Otoño;

            //se puede usar igualdad
            if (estacion==estacion1)
            {
                Console.WriteLine("Las estaciones son iguales.");
            }
            else
            {
                Console.WriteLine("Las estaciones no son iguales.");
            }
        }
        public static void castEnum()
        {
            Estaciones estaciones = Estaciones.Invierno;
            Console.WriteLine((int)estaciones);//Imprime el número del índice
        }
    }
}
