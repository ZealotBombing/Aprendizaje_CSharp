using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class DeclaracionDeProperties
    {
        private int _campo;
        private int _otroCampo;
        private string _campoDeSoloLectura;
        private bool _campoDeSoloEscritura;
        private double _campoAccesiblidad;

        public int Campo
        {
            //Esto es una property
            //se pueden aplicar a struct
            
            get { return this._campo; }
            set { this._campo = 1; }
        }
        public int OtroCampo
        {
            get { return this._otroCampo; }
            set { this._otroCampo = VerificarOtroCampo(value);/*esta cosa de value está buena*/  }
        }
        public string CampoDeSoloLectura//no tiene set, por lo tanto no se puede asignar nada
        {
            get { return this._campoDeSoloLectura; }
        }
        public  bool CampoDeSoloEscritura
        {
            set{ this._campoDeSoloEscritura = value; }//
        }
        private static int VerificarOtroCampo(int otroCampo)
        {
            return otroCampo < 0 ? 1 : 0;//por decir algo
        }
        public double CampoAccesibilidad
        {
            get { return this._campoAccesiblidad; }
            private set { this._campoAccesiblidad = value; }//se puede sobreescribir el modificador de acceso
            //se puede cambiar el modificador de acceso de uno solo de los accesors
            //No se puede poner un modificador menos restrictivo que la propiedad, si la prodiedad es privada el accesor no puede ser público
        }
    }
    class UsoDeProperties
    {
        public static void LlamarProperty()
        {
            DeclaracionDeProperties declaracion = new DeclaracionDeProperties();
            int n = declaracion.Campo;//llama a declaracion.Campo.get porque lo está asignando
            int m = declaracion.OtroCampo;//lo mismo

            declaracion.Campo = 1;//Es de escritura, por tanto llama a declaracion.Campo.set
            declaracion.OtroCampo = 2;//Idem(se pasa autompaticamente a value)

            declaracion.OtroCampo += 10;//Se llaman ambos métodos porque debe leerlo y después asignarlo

            //las properti es también pueden ser estáticas

            //declaracion.CampoDeSoloLectura = "1"; esto es ilegal
            string j = declaracion.CampoDeSoloLectura;//esto es legal

            declaracion.CampoDeSoloEscritura = true;//esto es legal
            //bool k = declaracion.CampoDeSoloEscritura; esto es ilegal
            //las propeties de solo escritura son útiles para resguardar datos como son las contraseñas
            //
        }
        public static void UsarRestriccionesDeLasProperties()
        {
            DeclaracionDeProperties declaracion;//no se ha iniciad
            //declaracion.Campo = 40; por lo tanto esto sería ilegal
            //si fuera un campo se podría

            //no se se puede usar una property como un argumento ref o out
            //si se puede hacer con un campo escribible
            //las properties no apunta a un espacio en la memoria, apuntan a un método accesor


            //Un property sólo puede contener un get y un set. No puede contener otros métodos, campos o properties

            //los accesores get y set no pueden recibir parámetros, para eso está el value

            //no se pueden declarar properties con const
        }
    }
    //uso apropiado de las properties
    class CuentaDeBanco
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return this._balance; }
            set { this._balance = value; }
            //esto es pobre porque no representa la funcionalidad necesaria para girar o depositar dinero
            //Hay que expresar el problema de mejor manera
        }
    }
    class CuentaDeBancoII
    {
        private decimal _balance;
        public decimal Balance { get { return this._balance; } }
        public void Depositar(decimal monto)
        {

        }
        public bool Girar(decimal monto)
        {
            return true;
        }
        //este diseño expresa de mejor manera el proceso
    }
    //tambien se pueden declarar properties en una interfaz
    interface IInterfaz
    {
        int X { get; set; }
        int Y { get; set; }
        //hay que decir pero filo, más adelante
    }
    //properties automáticas
    class Circulito
    {
        
        public int Radio { get; set; }//CHA CHAN!
        public DateTime FechaCirculo { get; }//Read only
        public DateTime OtraFecha { get; } = DateTime.Now;//También se puede declarar
        //no se puede crear una property automática de solo escritura
    }
    enum TipoDeTriangulo { Escaleno, Isosceles,Equilatero}
    class Triangulo
    {
        //iniciar constructores con 
        private int lado1 = 10;
        private int lado2 = 10;
        private int lado3 = 10;
        private TipoDeTriangulo tipo;

        public Triangulo(TipoDeTriangulo tipo)
        {
            this.tipo = tipo;
        }
        public int Lado1
        {
            set { this.lado1 = value; }
        }
        public int Lado2
        {
            set { this.lado2 = value; }
        }
        public int Lado3
        {
            set { this.lado3 = value; }
        }
        //así es más fácil. Info en la pag 419
        //esta sintaxis se conoce como iniciador de objeto
        //Esta wea se puede iniciar así
        //Triangulo triangulo = new Triangulo(TipoDeTriangulo.Equilatero) { Lado1 = 1, Lado2 ... };
        //los demás parámetros serán por defecto
    }
    //ejercicio del libro

    class Poligono
    {
        public int NumeroLados { get; set; }
        public double LongitudLados { get; set; }
        public Poligono()
        {
            this.NumeroLados = 4;
            this.LongitudLados = 10.0;
        }
    }
}
