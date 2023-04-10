using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class BaseClass //clase base
    {
    }
    class DerivedClass : BaseClass //DerivedClass hereda de BaseClass
    {

    }
    class DerivedSubClass : DerivedClass //Clase heredada de DerivedClass que también hereda de BaseClass
    {

    }
    class Mamifero : Object //esto se puede hacer explícitamente pero es innecesario
    {
        protected int campo;
        private string nombre;//campo de la clase base

        public Mamifero(string nomnbre)//constructor de la clase base
        {
            this.nombre = nombre;
        }
        public void Respirar()
        {

        }
        public void Amamantar()
        {

        }
        public void Hablar(int n, char z)
        {
            //este método asume que todos lo mamíferos hablan
        }
        public virtual string GetNameType()
        {
            return "Este es un mamífero.";
        }
    }
    abstract class Herviboro : Mamifero, IPastable
    {
        //esta clase es para evitar la duplición de código, por lo tanto no se puede instanciar
        public Herviboro(string nombre) : base(nombre) 
        {
            //se supone que una clase abstracta no se puede instanciar pero esta wea no me deja no crear un constructor
        }
        public abstract void DigerirPasto();//Los métodos  abstractos no llevan cuerpo, las clases hijas deben imprementarlos y sobreescribirlos
    }
    sealed class Caballo : Herviboro, ITerrestres, IPastable //hereda de la interfaz ITerrestres
    {
        //esta clase está sellada para que ninguna otra clase la use como base
        //Las clases selladas no pueden llevar métodos vituales y las clases abstractas no pueden ser selladas
        //también se pueden sellar los métodos, peroe esa parte aun no la entiendo
        public Caballo(string nombre) : base(nombre)//constructor la clase derivada
        {
            
        }
        public void Trotar()
        {

        }
        new public void Hablar(int x, char y)
        {
            //este método tiene la misma firma(signature) que el de su calse base, lo que quiere decir que se llama igual y recibe los mismos parámetros
            //este método oculta el método Hablar(int n, char z) de la clase base mamíferos, por lo tanto arroja una advertencia
            //con la palabra reservada new se deparece esa advertencia. Eso es todo
        }
        public override string GetNameType()
        {
            return "Este es un caballo.";
        }
        int ITerrestres.NumeroDePatas()//Se podría no poner el nombre de la interfaz en caso de haber interfaces múltiple
        {
            return 4;
            //la signatura del método debe ser la misma, eso incluye si los parámetros llevan la palabra reservada ref y out
        }

        public override void DigerirPasto()
        {
            throw new NotImplementedException();
        }
    }
    class Ballena : Mamifero //la herencia es siempre implpicitamente pública
    {
        public Ballena(string nombre) : base(nombre)//aun no entiedo bien esto del constructor base
        {

        }
        public void Nadar()
        {

        }
        public override string ToString()
        {
            return base.ToString();
            //esto debo estudiarlo mejor
        }
        public override string GetNameType()
        {
            return "Este es una ballena.";
        }
    }
    class OsoHormiguero : Mamifero
    {
        private string nombre;
        public OsoHormiguero(string nombre) : base(nombre)
        {
            this.nombre = nombre;
        }
    }
    class Humano : Mamifero
    {
        public Humano(string nombre) : base(nombre)
        {

        }
        ~Humano()
        {
            //esto es un destructor
            //se usan solo en tipos de referencia, no en tipos de valor
            //No tienen modificador de acceso
            //No reciben parámetros porque no se llaman manualmente
            //El compilador transforma este método en una sobreescriture del métodod Objecr.Finalize
            //Nunca sabes cuándo correrá este destructor       
        }
        public static void AsignaClases()
        {
            Caballo caballo = new Caballo("Pepito");
            Caballo caballo1 = caballo;//esto se puede hacer
            //Ballena ballena = caballo; //no se puede hacer esto¨*/

            //se puede asignar un objeto superior a un objeto inferior
            Mamifero mamifero = new Mamifero("King Kong");
            mamifero = caballo1;//esto es legal

            Mamifero mamifero1 = new Mamifero("Fernanda");
            Caballo caballo2 = new Caballo("Cristian");
            mamifero1 = caballo2;
            mamifero1.Respirar();//legal
            //mamifero1.Trotar()//ilegal

            //no se puede asignar una variable Mamifero a Caballo porque no todos los mamíferos son caballos

            //hasta acá se da a entender porqué se puede aignar casi cualquier cosa a una variable de tipo object
            //object es un alias para System.Object y todas las clases derivan de esa clase
            int n = 1;string m = "F";bool z = false; Caballo caballo3 = new("Napoleón");
            object a = n; object b = m; object c = z; object d = caballo3; 
            //aunque por alguna razón no puedo llamar al método Respirar() de Mamifero desde la variable d
        }
        public static void AsignarAJerarquiarMenoresOAlgoAsi()
        {
            //esto lo hice en el proyecto de espacialidad, ahora lo comprenderé, creo
            Caballo caballo = new Caballo("Blanco");
            Mamifero mamifero = caballo; //mamifero refererencia a Caballo

            Caballo caballo1 = mamifero as Caballo; //esto legal porque mamifero era un caballo

            Ballena ballena = new Ballena("Willy");
            Mamifero mamifero1 = ballena;
            mamifero1 = ballena;
            caballo1 = mamifero1 as Caballo; //esto devuelve nulo porque mamifero 1 era una ballena o algo así
        }
        public static void MetodosVirtualesYPolimirfismo()
        {
            //Mamífero tiene un metodo virtual, Caballo y Ballena tienen override y oso hormiguero no tiene

            Mamifero mamifero;
            Caballo caballo = new Caballo("");
            Ballena ballena = new Ballena("");
            OsoHormiguero osoHormiguero = new OsoHormiguero("");

            mamifero = caballo;
            Console.WriteLine(mamifero.GetNameType());//Este es un caballo

            mamifero = ballena;
            Console.WriteLine(mamifero.GetNameType());//Esta es una ballena

            mamifero = osoHormiguero;
            Console.WriteLine(mamifero.GetNameType());//Este es un mamífero

            //como el método es virtual se llama al de las clases derivadas
            //como el tercero no tiene así que llama al de mamífero
            //misma instruccion llamando a distintos métodos dependiendo del contexto se llama polimorfismo
        }
        public static void UsarProtected()
        {
            Humano humano = new Humano("Pepito");
            humano.campo=1;//se puede acceder desde aquí pero no desde otra clase fuera de la jerarquía 
        }
        public  static void ReferenciarClaseMedianteInterfaz()
        {
            Caballo caballo = new Caballo("Mora");
            ITerrestres iCaballo = caballo; //esto funciona porque los caballos son terrestres

            //también esto sirve para especificar a qué interfaz pertenece un método en caso de haber ambigüedad
        }
        public static int EnContrarVelocidadTerrestre(ITerrestres terrestres)
        {
            //este método recibe cualquier argumento que implemente la interfaz ITerrestres
            if(terrestres is ITerrestres)//se puede verificar si una instancia implementa una iterfaz
            {
                return 1;
            }
            int velocidad = 0;
            return velocidad;

            //cuando se implementa una interfaz se pueden invocar solo métodos que son visibles a través de la interfaz
        } 
        public virtual string ToString()
        {
            return nameof(Humano);
            //este método es la sobreescritura del método ToString() de la clase Object
            //este método no oculta el método de la calse base, solo lo implementa de otra manera
            //la diferencia con overdrive es... no sé

            //los métodos virtuales no pueden ser privados
            //deben tener la misma signature(mismo nombre, parámetros y deveolver el mismo tipo)
            //los métodos sobreescritos deben ser virtuales
            //sin la palabra override se oculta el mpetodo base
            //Un método sobreescrito es implicitamente virtual en la clase en la que se está sobreescribiendo, lo que quiere decir que se puede
            //...sobreescribir en clases derivadas. No se puede especificar manualmente un método sobreescrito como virtual
        }
    }
    //Los struct no se pueden heredar, ellos heredan de System.ValueType

    //Ejercicio del libro

    class Vehiculo
    {
        public void Encender(string ruidoQueHaceAlEncender)
        {
            Console.WriteLine($"Encendiendo: {ruidoQueHaceAlEncender}");
        }
        public void Apagar(string ruidoQueHaceAlApagar)
        {
            Console.WriteLine($"Apagando: {ruidoQueHaceAlApagar}");
        }
        public virtual void Manejar()
        {
            Console.WriteLine("Implementación por defecto del método Manejar()");
        }
    }
    class Aeroplano : Vehiculo
    {
        public void Despegar()
        {
            Console.WriteLine("Despegando.");
        }
        public void Land()
        {
            Console.WriteLine("Aterrizando");
        }
        public override void Manejar()
        {
            Console.WriteLine("Volando.");
        }
    }
    class Auto : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando.");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando");
        }
        public override void Manejar()
        {
            Console.WriteLine("Corriendo.");
        }
    }

    //extensiones
    static class Util //los métodos de extensiones se definen dentro de una clase estática
    {
        public static int ConvertirABase(this int i, int baseAConvertir)//la palabra this indica que es el método es una extensión del tipo int
        {
            if (baseAConvertir <2 || baseAConvertir > 10)
            {
                throw new ArgumentException("No se puede convertir a base " + baseAConvertir.ToString());
            }

            int resultado = 0;
            int iteraciones = 0;

            do
            {
                int nextDigit = i % baseAConvertir;
                i /= baseAConvertir;
                resultado += nextDigit * (int)Math.Pow(10, iteraciones);
                iteraciones++;
            } while (i != 0);

            return resultado;
        }
    }
    interface Interfaz //todas las interfaces se definen con I al principio
    {
        int CompararCon(object odj); //sólo se declara
        //las interfaces no pueden tener campos
        //no llevan constructores
        //no llevan destructores
        //No se puede específicar ningún modificador de acceso a un método, todos son implícitamente públicos
        //No se puede anidar ningún tipo dentro dentro de una interfaz(ni clases, ni struct ni ná)
        //Una interfaz no puede heredar de un struct o una clase, sólo de otra interfaz
    }

    //Ejemplo
    interface ITerrestres //esta interface se puede implementar en la clase caballo
    {
      int NumeroDePatas();
    }
    interface IPerritos : ITerrestres //una interfaz puede heredar de otra, si una clase hereda de una interfaz
    {

    }
    interface IPastable
    {

    }

    //información importante sobre CLR y WinRT o una wea así

    //Todos los campos públicos, los parámetros y los valores de retorno de cada método
    //público deben ser de los tipos de WinRT o tipos de .Net que pueden ser transparentemente
    //trasladados por WinRT a tipos de WinRt

    //Las clases no pueden sobreescribir metodos del la clase Object excepto ToString y no pueden
    //declarar constructores protegidos

    //El namespace en la cual una clase está definida debe ser del mismo nombre de la assembly(???)
    //El namespace no puede empezar por windows

    //No se puede heredar desde tipos gestionados a aplicaciones no gestionadas a través de WinRT
    //Por lo tanto todas las clases públicas deben ser selladas
    //Si se necesita implementar polimorfismo, se puede crear una interfaz pública
    //e implementarla en la clases que serán polimórficas

    //se puede lanzar cualquier tipo de excepción que esté incluida en el subconjunto de .NET disponible para
    //aplicaciones UWP. No se puede crear su propias clases de excepciones. Si el código
    //lanza una excepciín sin manejar  cuando es llamada desde una aplicación sin gestionar, WinRT
    //levanta(?rises) una excepción equivalente en el código sin gestionar


}
