using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class TryCatch
    {
        public static void primerTC()
        {
            int[] vs = new int[5];
            int n = 1;
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    vs[i] = n;
                    n++;
                }
            }catch(Exception e)
            {
                Console.WriteLine("Fuera de rango.");
                Console.WriteLine(e.ToString());//información del objeto Exception
                string msg = e.Message;//propiedad del objeto Exception que contiene el mensaje  de excepción
                Console.WriteLine(msg);
            }
        }

        //se reacomoda el try catch en el tercer método para no duplicarlo
        public static int bound()
        {
            int[] vs = new int[5];
            int n = 1;
            int m = 0;
            for (int i = 0; i < 5; i++)
            {
                vs[i] = n;
                n++;
                m += vs[i];
            }
            return m;
        }
        public static int format()
        {
            Console.WriteLine("Ingresar número:");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void sumar()
        {
            try
            {
                int n = TryCatch.bound();
                int m = TryCatch.format();
                int ñ = m + n;
                Console.WriteLine(ñ);
            }catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //el valor maximo de un int es 2147483647, si le se le suma 1 a este valor, el int dará negativo 
        //con la keyword checked dará lanzará na excepción
        public static void chequear()
        {
            int number = int.MaxValue;
            checked
            {
                int n = number++;//superará el valor máximo
                Console.WriteLine("Se excedió!");
            }
        }//checked solo aplica a los int dentro de los {}, no aplica a los métodos

        public static void nochequear()
        {
            int number = int.MaxValue;
            unchecked
            {
                int n = number++;//superará el valor máximo
                Console.WriteLine("No se excede!");
            }
        }//checked y unchecked funciona solo con int y long (al parecer)
        public static int ChequearMul(int n1, int n2)
        {
            string res;
            Console.WriteLine("Check? y/n");
            res = Console.ReadLine();
            if (res == "y") return checked(n1 * n2);
            else if (res == "n") return unchecked(n1 * n2);
            else
            {
                Console.WriteLine("Ingrese un opcion válida.");
                return 0;
            }
        }
        private static int ingresarN1()
        {
            Console.WriteLine("Ingrese un número entero:");
            int n1 = int.Parse(Console.ReadLine());
            return n1;
        }
        private static int ingresarN2()
        {
            Console.WriteLine("Ingrese otro número entero:");
            int n2 = int.Parse(Console.ReadLine());
            return n2;
        }
        public static void ChequearMul()
        {
            try
            {
                int resultado = checked(TryCatch.ingresarN1() * TryCatch.ingresarN2());
                Console.WriteLine("EL resultado es {0}", resultado);
            }catch(FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
                Console.WriteLine(fEx.ToString());
            }catch(OverflowException oEx)
            {
                Console.WriteLine(oEx.Message);
                Console.WriteLine(oEx.ToString());
            }
        }
        
        //el uso del throw
        public static void caseConThrow()
        {
            Console.WriteLine("Ingrese número del mes:");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Ese mes no existe");
                    //no sé si funcionó
            }
        }
        public static double dividirPorCero()
        {
            try
            {
                int n = 0;
                int m = 3;
                int res = m / n;
                return res;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                return 0;
                //float no arroja error según el libraco
            }
            finally
            {
                TryCatch.dividirPorCero();//parece que así funciona
            }
        }
        public static void correrDeTodosModos()
        {
            int numero;
            try
            {
                Console.WriteLine("Ingresar número:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine(numero);
            }catch(FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Intentar de nuevo?y/n");//debo hacer que este código no corra si se hizo bien el try
                string res = Console.ReadLine();
                switch (res)
                {
                    case "y":
                        TryCatch.correrDeTodosModos();
                        break;
                    case "n":
                        break;
                    default:
                        Console.WriteLine("Se tomará como un no.");
                        break;
                }

            }
        }
        public static void abrirArchivo()
        {
            System.IO.StreamReader archivo = null;
            try
            {
                string linea;
                int contador = 0;
                string path = @"C:\Users\cfuen\OneDrive\Escritorio\Libro\marquc3a9s-de-sade-la-filosofc3ada-en-el-tocaor.pdf";//falta una "d" en "tocador"
                archivo = new System.IO.StreamReader(path);
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión cerrada");
                
            }
        }

    }
}
