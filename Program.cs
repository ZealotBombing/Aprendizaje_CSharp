using System;

namespace RepositorioCentral
{
    class Program
    {
        static void doWork()
        {
            // TODO:
            /*Punto origen = new Punto();
            Punto bottomRight = new Punto(1366,768);
            double distancia = origen.DistanciaA(bottomRight);
            Console.WriteLine($"La distancia es: {distancia}");
            Console.WriteLine($"Número de puntos: {Punto.ContadorDeObjeto()}");*/

            //aquí empieza el ejercicio sobre valores y referencias
            /*int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            //este método recibe la variable i que pasa a ser param, pero es una copia del valor
            //la varieble i en este método sigue siendo 0
            Console.WriteLine(i);*/

            /*Wrapped wi = new Wrapped();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);//el valor cambia porque es un parámetro de referencia*/

            //ejercicio de enum
            /*Mes primero = Mes.Diciembre;
            Console.WriteLine(primero);
            primero++;
            Console.WriteLine(primero);*/
            //una vez que se supera el último elemento de
            /*Fecha defaultFecha = new Fecha();//constructor por defecto
            Console.WriteLine(defaultFecha);*/

            /*Fecha aniversarioDeBodas = new Fecha(2015, Mes.Julio, 4);
            Console.WriteLine(aniversarioDeBodas);*/

            /*Fecha ahora = new Fecha(2012, Mes.Marzo, 19);
            Fecha copiaFecha = ahora; //solo se puede asignar a una copia la variable de la derecha está inicializada

            Fecha now;
            Fecha copiaNow = now;//esto da error porque "now" no está inicializada*/

            /*Fecha copiaAniversario = aniversarioDeBodas;
            Console.WriteLine($"El valor de la copia es {copiaAniversario}");*/

            /*aniversarioDeBodas.AvanzarMes();
            Console.WriteLine($"Nuevo valor de aniversario de bodas es {aniversarioDeBodas}.");
            Console.WriteLine($"El valor de la copia sigue siendo {copiaAniversario}");
            //el valor de la variable cambia porque son variables de valor y se almacenan en la memoria stack
            //si Fecha fuera una clase el valor de la variable original y la copia serían el mismo*/

            //Console.WriteLine(Arrays.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            //Console.WriteLine(Arrays.Sum(2, 4, 6, 8));


            //ejercicio del libro sobre polimorfismo o herencia o algo así
            /*Console.WriteLine("Viajar en aeroplano: ");
            Aeroplano miAeroplano = new Aeroplano();
            miAeroplano.Encender("Contacto.");
            miAeroplano.Despegar();
            miAeroplano.Manejar();
            miAeroplano.Land();
            miAeroplano.Apagar("Whirr");

            Console.WriteLine("Viaje en auto.");
            Auto miAuto = new Auto();
            miAuto.Encender("Brum brum!");
            miAuto.Acelerar();
            miAuto.Manejar();
            miAuto.Frenar();
            miAuto.Apagar("Phut Phut!");

            Console.WriteLine("\nProbando polimorfismo");
            Vehiculo v = miAuto;
            v.Manejar();
            v = miAeroplano;
            v.Manejar();*/


            //ejercicio de extesiones
            /*int x = 591;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertirABase(i)}");
            }*/

            //Ejercicio properties
            /*Poligono cuadrado = new Poligono();
            Poligono triangulo = new Poligono { NumeroLados = 3 };
            Poligono pentagono = new Poligono { LongitudLados = 15.5, NumeroLados = 5 };
            */


        }
        const int numeroSuperior = 1;//variable de clase program

        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //Variables.DeclararVariables();

            //ejemplo de método
            //Metodos.mostrarValor(Metodos.restarValores(2,1));
            //Metodos.mostrarValor(numeroSuperior);//useo de clase program
            //Metodos.run();

            //parámetros opcionales
            /*Metodos.optMethod(3);
            Metodos.optMethod(4, 4.1);
            Metodos.optMethod(4, 4.1,"Hey!");
            Metodos.optMethod(second: 2.0, third: "Caca", first: 4);//se llama por nombre de parámetro
            Metodos.optMethod(first:99,third:"kk");//El segundo parámetro no se usa
            Metodos.optMethod(33, third: "challa");//Se mezclan lo nombres con las posiciones*/

            //bool n = true;
            /*Console.WriteLine(!n);
            Console.WriteLine(DecisionSt.bulear(-2, 3));
            Console.WriteLine(DecisionSt.orear(3,3));
            Console.WriteLine(DecisionSt.simplificar(4,4));
            Console.WriteLine(DecisionSt.simplificar(-2, -4));
            Console.WriteLine(DecisionSt.EvaluarSinOperador(false));
            Console.WriteLine(DateTime.Today.Date.ToString());*/
            //DateTime fecha1 = new DateTime().ToLocalTime();
            //DateTime fecha2 = new DateTime().ToLocalTime();

            //DecisionSt.mostrarCompraracion(fecha1,fecha2);
            //Console.WriteLine(fecha1.CompareTo(fecha2));//compara las fechas, duelve 0 si son iguales

            //DecisionSt.usarSwitch();
            //DecisionSt.cambiarCarateres();

            //Bucles.mostrarDato();

            //Console.WriteLine(Bucles.validarPar(2));
            //Console.WriteLine(Bucles.validarPar2(3));
            //Bucles.usarUnFor();
            //Bucles.usarOtroFor();
            //Console.WriteLine(Bucles.multiplicar(1, 5));
            //Console.WriteLine(Bucles.hacerSoloUnaInstruccion(1));
            //Bucles.usarContinuarYBreak();
            //Bucles.convertirAOctal(999);
            //TryCatch.primerTC();
            //TryCatch.sumar();

            //TryCatch.chequear();
            //TryCatch.nochequear();

            //Console.WriteLine(TryCatch.ChequearMul(9876543, 9876543));
            //TryCatch.ChequearMul();

            //TryCatch.caseConThrow();

            //Console.WriteLine(TryCatch.dividirPorCero());

            //TryCatch.correrDeTodosModos();

            //TryCatch.abrirArchivo();

            /*Circulo c;
            c = new Circulo();
            Circulo d = new Circulo();
            c = d;//se puede asignar un objeto a otro
            double areaDelCirculo = c.Area();
            Circulo f = new Circulo(45);
            double area2 = f.Area();
            Console.WriteLine(area2);*/

            //try
            //{
            //    doWork();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Console.WriteLine($"Número de circulos: {Circulo.NumCirculo}");

            //Program.doWork();

            //Variables.UsarVar();

            /*int arg = 42;
            Variables.usarRef(ref arg);//aquí incrementa la variable
            Console.WriteLine(arg);//esto muestra 43, sin ref mostraría 42*/

            /*int arg; //no se inicia
            Variables.iniciarVariable(out arg,23);//se puede asignar "arg" sin iniciar anteponiendo "out"
            Console.WriteLine(arg);//muestra un valor asignado el en método*/

            //Variables.unboxigConException(); arroja excepción

            //Enumenaciones.usarEnum();

            //complemento ejercicio struct
            /*int i = 55;
            Console.WriteLine(i.ToString());
            Console.WriteLine(66.ToString());
            float f = 98.345F;
            Console.WriteLine(f.ToString());
            Console.WriteLine(98.34F.ToString());*/
            //Todo esto es legal porque estos tipos de datos son alias de los structs (System.Int32,System.Int64)

            /*foreach (string item in args)
            {
                Console.WriteLine(item.ToString());
            }*/

            //Arrays.CopiarArray();

            //Console.WriteLine(Arrays.UsarParams(6,4,3,1));

            //Humano.MetodosVirtualesYPolimirfismo();

            //ejercicio Herencia:
            //doWork();

            //Triangulo triangulo = new Triangulo(TipoDeTriangulo.Equilatero) { Lado1 = 1 };

            //ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);
            //elDelegado();//aquí se llama
            //elDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            //elDelegado();
            //ObjetoDelegadoII elNuevoDelegado = new ObjetoDelegadoII(MensajeBienvenida.Saludar);
            //elNuevoDelegado("zar");
            //elNuevoDelegado = new ObjetoDelegadoII(MensajeDespedida.Despedir);
            //elNuevoDelegado("zar");

            //Binarius.NotBinario();
            //Binarius.ShiftOperador();
            //Binarius.OrBinario();

            //Departamento departamento = new Departamento();

            //Console.WriteLine(departamento[101].EmpName);
            //Console.WriteLine(departamento["Brad"].Id);

            //Queue<int> queue = new Queue<int>();

            //Tree<int> tree1 = new Tree<int>(10);
            //tree1.Insert(5);
            //tree1.Insert(11);
            //tree1.Insert(5);
            //tree1.Insert(-12);
            //tree1.Insert(15);
            //tree1.Insert(0);
            //tree1.Insert(14);
            //tree1.Insert(-8);
            //tree1.Insert(10);
            //tree1.Insert(8);
            //tree1.Insert(8);
            //string sortedData = tree1.WalkTree();
            //Console.WriteLine($"Sorted data is: {sortedData}");

            //int n = 1, m = 2;
            //DeMetodoGenerico.Intercambiar<int>(ref n, ref m);

            //Tree<char> charTree = null;
            //InsertIntoTree<char>(ref charTree, 'M', 'X', 'A', 'M', 'Z', 'N');//comillas simples porque son char
            //string sortedData = charTree.WalkTree();
            //Console.WriteLine($"Los datos ordenados son: {sortedData}");
            ////Me ahorré todo lo de arriba
            
        }
        //ejercicio método genérico
        static void InsertIntoTree<TItem>(ref Tree<TItem> tree, params TItem[] data) where TItem : IComparable<TItem>//se quitó el error de tree al implementar IComparable
        {
            //Entonces:
            //Un parámetro de tipo Tree<TItem> y otro de tipo TItem chaucha
            foreach(TItem datum in data)
            {
                if (tree == null)//si no hay arbolito (es ref así que null(creo))
                {
                    tree = new Tree<TItem>(datum);//el constructor recibe un nuevo nodo
                }
                else
                {
                    tree.Insert(datum);
                }
            }
        }

        //DELEGADO
        delegate void ObjetoDelegado();//debe llevar los mismos parámetros de los métodos que llama

        delegate void ObjetoDelegadoII(string msj);//mismos parámetros

       
    }
    class COM
    {
        
        //Component Object Model

    }
}