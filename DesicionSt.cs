using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class DecisionSt
    {
        public static void probar()
        {

        }
        public static bool bulear(int uno, int dos)
        {
            return uno > 0 && dos > 0;
        }
        bool respuesta = bulear(1, 2); //se puede asignar a una variable
        public static bool orear(int uno, int dos) => uno > 0 || dos > 0;
        public static string simplificar(int uno, int dos) => uno > 0 || dos > 0 ? "N" : "S";

        //Colocar expresiones booleanas simples a la izquierda y complejas a la derecha
        //Precedencia: && es más alto que ||

        //se puede usar directamente un bool en un if sin necesidad de usar ==
        public static bool EvaluarSinOperador(bool bul)
        {
            if (bul)
            {
                //aquí pueden ir variable locales
                return true;
            }
            else
            {
                return false;
            }
        }

        //replicando el metodo de comparar fechas del libro:

        public static int dateCompare(DateTime fecha1, DateTime fecha2) //en el libro es private y no void por que es un form
        {
            int result = 0;
            if (fecha1.Year < fecha2.Year)
            {
                result = -1;
            }
            else if(fecha1.Year > fecha2.Year)
            {
                result = 1;
            }else if (fecha1.Month < fecha2.Month)
            {
                result = -1;
            }else if (fecha1.Month > fecha2.Month)
            {
                result = 1;
            }
            else if (fecha1.Day < fecha2.Day)
            {
                result = -1;
            }
            else if (fecha1.Day > fecha2.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        public static void mostrarCompraracion(DateTime fecha1, DateTime fecha2)
        {
            int diff = dateCompare(fecha1, fecha2);//como retorna un valor int se puede asignar a una variable del mismo tipo
            Console.Write("firstDate == secondDate: ");
            Console.WriteLine(diff == 0);//WriteLine(bool)
            Console.Write("firstDate != secondDate: ");
            Console.WriteLine(diff != 0);
            Console.Write("firstDate < secondDate: ");
            Console.WriteLine(diff < 0);
            Console.Write("firstDate <= secondDate: ");
            Console.WriteLine(diff <= 0);
            Console.Write("firstDate > secondDate: ");
            Console.WriteLine(diff > 0);
            Console.Write("firstDate >= secondDate: ");
            Console.WriteLine(diff >= 0);

        }

        //switch
       /*switch (controllingExpression )
        {
            case constantExpression :
                statements
                break;
            case constantExpression :
            statements
                break;
            ...
            default :
            statements
            break;
            }*/
       //si no encuentra coincidencia en las opciones o en el match sigue con la siguiente instruccción

        public static void usarSwitch()
        {
            double flotante = double.Parse(Console.ReadLine());
            switch (flotante)
            {
                case 1.1 :
                    Console.WriteLine("Funciona?");
                    break;

                default:
                    Console.WriteLine("Parece que no");
                    break;
            }
            //el libro dice que no se puede usar con double o float, sí con string, int y char
            //reglas para usar un switch
            //1.-Lo de los datos
            //2.-los casos deben ser expresiones constantes (?)
            //3.-los case debe ser expresiones únicas
            //4.-Puede ser más de un case para una instrucción(se deben listar los case y al final la instrucción), no puede ser más de una instrucción para un case
            int entero = int.Parse(Console.ReadLine());
            switch (entero)
            {
                case 1:
                case 2:
                    Console.WriteLine("Uno o dos.");
                    break;
                case 3:
                    Console.WriteLine("Tres.");
                    break;
                case 4:
                    Console.WriteLine("Cuatro.");
                    break;
                default:
                    Console.WriteLine("Más de cuatro.");
                    break;
            }
            //se puede salir del switch también con return o throw en lugar de break
            
        }
        public static void cambiarCarateres()
        {
            string linea = Console.ReadLine();//ejercicio en pag 150 del libro
            switch (linea)
            {
                case "c":
                    linea += 'c';
                    break;
                case "a":
                    linea += 'x';
                    break;
                case "d":
                    linea += 'v';
                    break;
                default:
                    break;
            }
            Console.WriteLine(linea);
        }
        
    }
}
