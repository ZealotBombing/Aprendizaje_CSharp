using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Bucles
    {
        //buble while reglas:
        //-La expresión a evaluar debe ser booleana
        //-La expresión debe estar en paréntesis
        //-Si la expresión es falsa a la primera que se evaluea el while no corre
        //-Para hacer más instrucciones bajo el control de un while debe hacerce dentro de las claves de esta

        //ejemplo del libro:
        public static void mostrarDato()
        {
            string linea = "";
            Console.WriteLine("Ingresar línea:");
            string linea2 = Console.ReadLine();
            while (linea2 != "a")//en el libro dice null pero no pasó ná
            {
                linea += linea2 + "\n";
                linea2 = Console.ReadLine();
            }
            Console.WriteLine(linea);
        }
        public static bool validarPar(int numero)
        {
            return numero % 2 == 0;
        }
        public static string validarPar2(int numero)
        {
            return numero % 2 == 0 ? "Número par" : "Número impar";
        }

        //bucle for
        public static void usarUnFor()
        {
            for (int i = 0; i < 10; i++) Console.WriteLine(i);
            //las 3 partes del for son la inicialización, la expresión booleana y el update(no sé, incremento creo)
            //se puede escribir así pero se recomienda hacer {} por si se necesita incluir más instrucciones en el futuro
            //se puede omitir cualquiera de las 3 partes de un for
            //si se omite la expresión boolean (i<10) el bucle correrá por siempre
        }
        //se puede tener más de un incremento, pero solo una expresión booleana
        //las variables deben ire separadas por comas
        public static void usarOtroFor()
        {
            int[] vs = new int[3];
            int[] vs1 = new int[3];
            Console.WriteLine("Llenar array:");
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0,j = 2; i <vs1.Length; i++,j--)//ejemplo del libro:for (int i = 0, j = 10; i <= j; i++, j--)

            {
                vs1[j] = vs[i];
            }
            Console.WriteLine("Imprimiendo array:");
            for (int i = 0; i < vs1.Length; i++)
            {
                Console.WriteLine(vs1[i]);
            }
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
        //La expresión booleana  es si la variable
        //for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
        //    {
        //        source.Text += line + '\n';
        //    }


        //el do-while se executa al menos una vez
        public static int multiplicar(int inicio, int fin)
        {
            do
            {
                inicio++;
            } while (inicio < fin);

            return fin * inicio;
            //este método incrementa un número hasta que se del mismo tamaño del otro y luego los multiplica,
            //es más fácil hacer una raíz cuadrada pero no se me ocurrió nada más
        }
        
        public static int hacerSoloUnaInstruccion(int numero)
        {
            if (numero<10)
            {
                do numero++; while (numero <= 10);
                //se debe poner {} si el do lleva más de una instrucción, de otra forma se puede prescindir de ellas.
            }
            else
            {
                do numero--; while (numero >= 0);
            }
            return numero;
        }
        //uso de break y continue
        public static void usarContinuarYBreak()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
                if (i < 10) continue;//esta vendría siendo la condición
                else break; //y aquí se sale del bucle
            }
            //el libro dice que este código es refeo, hay que tener cuidado con usar continue
        }

        //hacer el ejercicio del libro
        public static void convertirAOctal(int dec)
        {
            int res;
            string seq="";
            int fnl;
            do
            {
                res = dec % 8;
                dec /= 8;
                seq += Convert.ToString(res);


            } while (dec!=0);
            fnl = int.Parse(seq);
            Console.WriteLine(fnl);
        }
    }
}
