using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Variables
    {
        //existen value types y reference types
        //los valores como int, float, double y char son tipos de valor
        //las clases son tipos de referencia
        //string cuenta como clase
        public static void VariableDeValor()
        {
            int i = 42;//aquí hay bloque de memoria para 42
            int copyi = i;//aquí hay otro bloque de memoria para otro 42
            i++;//esta instrucción no modifica copyi, sólo a i

            //por el contrario:
            Circulo c = new Circulo(42);//c referencia a un objeto círculo
            Circulo refc = c;//aquí se copia la misma "dirección" que referencia a un objeto círculo

            //esto es importante porque el comportamiento los parámetros de los métodos depende de
            //si son valores o referencias
        }
        public static void DeclararVariables()
        {
            //declarar
            int numero;
            float flotante;
            double doble;
            string linea;

            //asignar
            numero = 1;
            flotante = 1.0f;
            doble = 1.2;
            linea = "peo";

            //convertir
            string numeral = numero.ToString();
            Console.WriteLine(numeral);

            int numero3 = System.Int32.Parse(numeral);
            Console.WriteLine(numero3 + numero);

            //declarar mismo valor a varias variables
            numero = numero3 = 3;

            //incrementar o decrementar
            numero3++;
            numero--;

        }
        public static void UsarVar()
        {
            var objetoAnonimo = new { nombre = "Tatán", edad = 33 };
            //descubrí que var solo se puede usar dentro de un método
            //esta es un objetod e una clase anónima
            Console.WriteLine("Nombre: {0}, Edad: {1}", objetoAnonimo.nombre, objetoAnonimo.edad);
            var otroAnonimo = new { nombre = "Java", edad = 21 };
            //al tener los mismos campos con los mismos tipos se convierten en 
            //instancias de una misma clase

            //por lo anterior se puede hacer lo siguiente:
            objetoAnonimo = otroAnonimo;

            //solo deben tener campos públicos
            //deben estar inicializados
            //no pueden ser estáticos
            //no llevan métodos
        }
        public static void NullS()
        {
            Circulo c = null;//se usa para tipos de referencia no de valor
            if (c != null)
            {
                Console.WriteLine($"El area del círculo es {c.Area()}");
            }
        }
        public static void Nullable()
        {
            //int i = null;//mal
            int i = 0;
            int? y = null;//bien
            //i = y;//mal
            //como los tipos de valor no pueden contener null no se le puede asignar un nullable
            //tampoco se pueden usar como parámetros de un método que recibe tipos de valor ordinarios

            //los tipos nulables se crean en la memoria heap, donde se almacenan los objetos
        }
        public static void PropiedadesNull()
        {
            int i = 1;
            int? j = null;
            Console.WriteLine(j.Value);//funciona con j por ser nullable
            if (!j.HasValue)//otra propiedad de los nullable
            {
                Console.WriteLine(j.Value);
            }
        }

        public static void usarRef(ref int parametro)
        {
            parametro++;
        }

        //creo que lo siguiente se llama parámetros de salida
        //se usa cuando se quiere que el método asigne la variable
        //se usa la palabra reservada "out"
        //cada que un parámetro tenga la palabra "out" de prefijo, el método debe iniciarla

        public static void iniciarVariable(out int parametro1, int parametro2)
        {
            parametro1 = 12;//es obligatorio iniciar el parámetro o modificarlo 
        }

        object algo; //creo que esto es lo mismo que esto:
        Object otroAlgo = new Object();//pero es preferible lo primero

        public static void usarObject()
        {
            Circulo c;
            c = new Circulo(42);
            object o;
            o = c;
            //ahora "c" y "o" referencian al mismo objeto
        }
        public static void boxing()
        {
            int i = 42;
            object o = i;
            //la segunda línea manda una copia del valor de "i" a la memoria heap
            //modificar "i" no modificará la copia a la que referencia el objeto "o"
            object o1 = o;
        }
        public static void unboxingMal()
        {
            Circulo c = new Circulo();
            int i = 42;
            object o;

            o = c;//"o" referencia un circulo
            //i = o;   ilegal
        }
        public static void unboxingBien()
        {
            int i = 42;
            object o = i;
            i = (int)o;//cast. Extrae el valor referenciado y lo copia en i

        }
        public static void unboxigConException()
        {
            Circulo c = new Circulo(42);
            object o = c;//no hay boxing porque Circulo es una referencia
            int i = (int)o;//funciona pero arroja una excepción

        }

        //lo siguiente es para hecer cast seguro a las variables
        public static void usoDeIs()
        {
            Circulo c = new Circulo();
            object o = c;

            if(o is Circulo)//la palabra reservada "is" evalúa si la variable de referencia de la izquierda es del tipo indicado en la derecha
            {
                Circulo temp = (Circulo)o;//esto es seguro por que "o" es un circulo, entonces de puede hacer casting
            }
        }
        public static void udoDeAs()
        {
            Circulo c = new Circulo();
            object o = c;
            Circulo temp = o as Circulo;//aquí se trata de hace r cast con la variable "o"(o algo así)

            if (temp != null) Console.WriteLine("Cast was successful");
            else Console.WriteLine("Cast fail.");
        }
        public static int NoCambiar(in int parametro)
        {
            //parametro++; ilegal
            return parametro;
        }
        public string CambiarSiOSi(out string circulo)
        {
            circulo = "Hola circulo";
            return circulo;
        }

    }
}
