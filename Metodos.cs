using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Metodos
    {
        int cv = 2;//variable de clase

        //especificar el tipo que retorna
        //los parámetros de entrada son copia de las variables que entrada
        string RetornarCadena()
        {
            return "Cadenita";
        }

        //si no retorna nada escribir void
        void RetornarNada()
        {
            Console.WriteLine("Esto no es un retorno");
        }
        void RetornarNadaDeNada()
        {
            return;
        }

        //con parametros de entrada
        int RetornarEntero(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        void NoRetornarEnteros(int numero3)
        {
            Console.WriteLine("Imprime: " + numero3 + cv);//variable de clase cv usada
        }

        //expression-bodied method o algo así
        int sumarValores(int uno, int dos) => uno + dos;
        void mostrarResultado(int resultado) => Console.WriteLine($"El resuntado es", sumarValores(1, 2));

        //llamar métodos
        public static int restarValores(int uno, int dos) => uno - dos;//es estático para llamarlo

        int resultado = restarValores(3, 4);//la variable tiene el valor retornado

        public static void mostrarValor(int valor)
        {
            Console.WriteLine(valor);
        }

        //sobrecarga de métodos
        public static void SumarValores(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void SumarValores(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public static string SumarValores(int a, int b, string c)
        {
            return c + (a + b);
        }
        static int SumarValores(int a, int b, double c)
        {
            return c < 1 ? a + b : a - b;
        }

        // método del libro
        public static void run()
        {
            double dailyRate = readDouble("Ingrese su tarifa diaria:");
            int noOfDays = readInt("Ingrese el número de días:");
            writeFree(calculateFree(dailyRate, noOfDays));
        }

        //método generado con stub wizard
        private static double readDouble(string v)
        {
            Console.Write(v);//el parámetro de entrada("Ingrese tarifa diaria")
            string line = Console.ReadLine();//variable local. ReadLine devuelve un valor, por eso se parsea
            return double.Parse(line);
        }
        private static int readInt(string v)
        {
            Console.Write(v);//"Ingrese el número de días
            string line = Console.ReadLine();
            return int.Parse(line);
        }
        private static double calculateFree(double dailyRate, int noOfDays) => dailyRate * noOfDays;
        //se cambia object por double

        private static void writeFree(double v) => Console.WriteLine($"La tarifa de la consulta es:{v * 1.1}");
        //extraer método, averiguar

        //parámetros opcionales
        public static void optMethod(int first, double second = 0.0, string third = "Hello")
        {
            //el primer parámetro es obligatorio y los otros dos opcionales
        }
        //se pueden llamr por los nombres de los parámetros

        //Las llamadass por nombre se pueden resolver la ambiguedad
        /*void optMethod(int first, double second = 0.0, string third =
        "Hello")
        {
        ...
        }
        void optMethod(int first, double second = 1.0, string third =
        "Goodbye", int fourth = 100 )
        {
        ...
        }*/

        //Si se llama al segundo método son ingresar el cuarto parámetro por ser opcional, este invocará al primero
        //optMethod(1, 2.5, "World");
        //en cambio si se usa el nombre de la variable esta llamará al que corresponde
        //optMethod(1, fourth : 101);
        //La siguiente llamada no calza con ninguna
        //optMethod(1, 2.5);
        static void RecordatorioOut(out int numero)
        {
            numero = 1;//se debe asignar dentrto del método
            RecordatorioOut(out numero);
        }
        
        
    }
}
