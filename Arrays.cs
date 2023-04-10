using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Arrays
    {
        int[] pins = new int[4]; //declarar e iniciar un array un array
        Circulo[] circulos;//pueden ser clases
        Fecha[] fechas;//Pueden ser struct
        Mes[] meses;//pueden ser enum
        //todos los array son tipos de referencia
        //no se guarda el¿n heap hasta que se inicie su tamaño, solo guarda en stack la referencia

        public static void declararArray()
        {
            //el tamaño del array no debe ser constante
            int size = int.Parse(Console.ReadLine());
            int[] pins;
            pins = new int[size];

            //se puede hacer un array de tamaño 0, lo cual no sería nulo
            //antes de llenar un array los valores se incian en su valor por defecto(0,null)

            int[] pins1 = new int[4]{ 9, 7, 5, 3 }; //se puede inciar el array al mismo tiempo que se declara
            //debe tener la cantidad de elementos que indíca el tamaño del array
            // se puede omitir la palabra new
            int[] pins3 = { 9, 7, 5, 3 };//en este caso, el compilador calcula el tamaño del array
            //los valores no tienen porqué ser constantes, se pueden calcular en el tiempo de ejecución

            Random r = new Random();
            int[] pins2 = new int[4] { r.Next() % 10, r.Next() % 10, r.Next() % 10, r.Next() % 10 };

            //array de objetos(y structs)
            Fecha[] fechas = { new Fecha(2020, Mes.Abril, 12), new Fecha(2022, Mes.Agosto, 15) };
        }
        public static void crearArrayImplicito()
        {
            //se puede declarar un array sin específicar el tipo y dejar que el compilador lo determine

            var names = new[] { "Leonardo", "Donatello", "Rafael", "Miguel Ángel" };
            //var no lleva brackets, new sí

            var numbers = new[] { 1, 2, 3.5, 5 };//por 3.5 esto es un array de tipo double

            var objects = new[] { new { nombre = "Fernanda", edad = 24 }, new { nombre = "Jack", edad = 7 }, new { nombre = "Cristian", edad = 33 }, new { nombre = "Catalino", edad = 44 } };
            //array de objetos implícitos
            //los campos de cada objetos deben ser los mismos
            //util para trabajar con clases anónimas
        }
        public static void ManejarElementosDelArray()
        {
            int[] pins = new[] { 2, 4, 6, 8 };
            int myPin;
            myPin = pins[0];//se asigna el valor del índice 0(2) a myPin


            int[] pins1 = new int[4];
            int myPin2=2;
            pins1[1] = myPin2;//se asinga el valor myPin2 al índice 1

            //si el intenta usar un índica menor que 0 o mayor o igual a la longitud del array, se arrojará un error
        }
        public static void IterarArray()
        {
            //todos los arrays son instancias de la clase System.Array, por eso son referencias
            //por lo tanto cada array tiene propiedades y métodos

            int[] pins = { 9, 3, 7, 2 };
            for (int i = 0; i < pins.Length; i++)//útil si no se sabe la longitud del array
            {
                int pin = pins[i];//se asigna el valor el índice a pin
                Console.WriteLine(pin);//se imprime pin
            }
            foreach(int pin in pins)//pin es la variable de iteración
            {
                Console.WriteLine(pin);
            }
            //usar foreach si se quiere iterar el array entero
            //foreach siempre itera desde el índice 0 al Lenght-1. Si se quiere iterar al revés mejor usar for
            //si la dentro de la función se necesita saber el índice del elemento hay que usar for
            //el foreach es de solo lectura, si se quiere modificar los elementos del array hay que usar for

            //si no se sabe el tipo de dato de un array o si son objetos anónimos se puede usar var para la variable de iteración

            var nombres = new[] { new { nombre = "John", edad = 50 }, new { nombre = "Diana", edad = 50 }, new { nombre = "James", edad = 23 }, new { nombre = "Francesca", edad = 21 } };
            foreach(var miembro in nombres)
            {
                Console.WriteLine($"Nombre: {miembro.nombre}, edad: {miembro.edad}");
            }
        }
        //pasar arrays como parámetros
        public void ProcessData(int[] data)//NOTA: los arrays son tipos de referencia, lo que se haga a la copia le pasará al original
        {
            foreach (int item in data)
            {
                //...
            }
        }

        //devolver un array
        //se debe especificar el tipo de dato con los corchetes
        public int[] ReadData()
        {
            Console.WriteLine("¿Cuántos elementos?");
            string respuesta = Console.ReadLine();
            int cantidad = int.Parse(respuesta);

            int[] data = new int[cantidad];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Ingrese elemento para el índice {i}");
                respuesta = Console.ReadLine();
                int valor = int.Parse(respuesta);
                data[i] = valor;
            }
            return data;
        }

        //int[] data = ReadData(); se llama así

        public static void CopiarArray()
        {
            int[] vs = { 2, 4, 6, 8 };
            int[] copiaVs = vs;//ambos referencian a la misma instancia

            //Para copiar los datos del heap se debe declarar un array con la misma longitud del original
            int[] vs1 = { 2, 4, 6, 8 };
            int[] copiaVs1 = new int[vs1.Length];//esta está wena
            for (int i = 0; i < vs1.Length; i++)
            {
                copiaVs1[i] = vs1[i];
            }
            Console.WriteLine(copiaVs);//acabo de descubrir que esto imprime System.int32 o algo así

            string[] vs2 = { "perro", "gato", "cobaya" };
            Console.WriteLine(vs2);//y esto imprime System.String
        }
        public static void UsarCopyTo()
        {
            int[] pins = { 9, 7, 5, 3, 1 };
            int[] copy = new int[pins.Length];
            pins.CopyTo(copy, 0);//el array donde se copiará y el índice donde empieza

            int[] pins2 = { 5, 10, 15, 20 };
            int[] copy2 = new int[pins2.Length];
            Array.Copy(pins2, copy2, copy2.Length);//el tercer parámetro es la cantidad de elementos a copiar
        }
        public static void UsarClone()
        {
            int[] pins = { 9, 7, 5, 3, 1, };
            int[] copy = (int[])pins.Clone();//este no lo entiendo
        }
        public static void DeclararArraysMultidimensionales()
        {
            int[,] items = new int[4, 6];//era más fácil de lo que lo recordaba

            items[2, 3]= 99;//iniciar una celda
            items[2, 4] = items[2, 3];//copiar el valor de una celda a otra
            items[2, 4]++;//incrementar el valor de una celda

            //no hay límite dimensiones
            int[,,] cubo = new int[5, 5, 5];
            cubo[1, 2, 1] = 101;
            cubo[1, 2, 2] = cubo[1, 2, 1] * 3;
            //se recomienda usar un catch con OutOfMemoryException cuando se usen arrays de más de 3 dimensiones
        }
        public static void CrearArrayDenatado()
        {
            //jagged array
            //se usa para ocupar la memoria justa
            int[][] items = new int[4][];
            int[] colunmForRow0 = new int[3];
            int[] colunmForRow1 = new int[10];
            int[] colunmForRow2 = new int[40];
            int[] colunmForRow3 = new int[25];
            items[0]= colunmForRow0;
            items[1]= colunmForRow1;
            items[2]= colunmForRow2;
            items[3]= colunmForRow3;
            //no entendí mucho esta parte
            //primero se hace un array de arrays
            //luego se asigna la longitud del array que serían las columnas, cada una de ellas contiene un array de tamalo indeterminado
            //se declaran los arrays que irán en cada columna
            //se asigna el array a cada columna AAAAAAAAAAAH ya entendí

            //se puede asignar valor a cada posición así:
            colunmForRow0[1] = 99;
            items[0][1] = 99;//ambos 
             
        }
        public static int UsarParams(params int[] listaParametros)
        {
            //si se llama de la siguiente manera: UsarParams(1,2,3)
            //los parámetres se meterán dentro de un array sin necesidad de declararlo y llenarlo fuera del método
            if (listaParametros == null || listaParametros.Length == 0)
            {
                throw new ArgumentException("No hay suficientes parámetros.");
            }
            int minimoDefecto = listaParametros[0];
            foreach (int i in listaParametros)
            {
                if (i<minimoDefecto)
                {
                    minimoDefecto = i;
                }
            }
            return minimoDefecto;
            //los métodos basados unicamente en params no se se pueden sobrecargar
            //no se puede epecificar los modificadores ref o out(No recuerdo que era eso)
            //un params array debe ser el último parámetro de un método, por lo tanto también el único
        }
        public static void SobrecargarParam(int n, int m)
        {

        }
        public static void SobrecargarParam(params int[] paramList)
        {
            SobrecargarParam();//llama al segundo porque puede tomar cualquier cantidad de enteros, incluso 0
            SobrecargarParam(2, 1);//llama al primero
            SobrecargarParam(1, 2, 2);//llama al segundo
        }
        //el siguiente método crea un array de tipo object, así se pueden meter parámetros de cualquier tipo mediante el boxing

        public static void BlackHole(params object[] paramlist)
        {
            BlackHole();//crea un array object[0]
            BlackHole(null);//como los arrays son referencias se puede usar null

            //se puede hace un array de objetos varios y meter el método
            object[] array = new object[3];
            array[0] = "Perro";
            array[1] = 42;
            array[2] = new { nombre = "Lio", especie = "Gato", edad = 2 };
            BlackHole(array);

            //o meter los objects directamente el método
            BlackHole("Gatito",2,new { nombre="Cristian",edad=33},true);

            //está too wapo, ahora comprendo un poco más Python, creo

            Console.WriteLine('1');
        }

        //ejercicio del libro
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Usando lista de parámetros.");
            if (paramList == null)//manejo de las excepciones
            {
                throw new ArgumentException("No hay suficientes parámetros.");
            }
            if (paramList.Length == 0)
            {
                throw new ArgumentException("La lista está vacía.");
            }
            int sumTotal = 0;
            foreach (int i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }
        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Usando parámetros opcionales.");
            int sumTotal = param1 + param2 + param3 + param4;
            return sumTotal;
        }
    }
}
