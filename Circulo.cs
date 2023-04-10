using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    partial class Circulo:IComparable<Circulo>
    {
        private int radio;
        public static int NumCirculo = 0;//identidicadores privados empiezan con minúscula

        public Circulo()//el constructor por defecto es público, el creado es privado
        {
            radio = 0;
            NumCirculo++;
        }
        public Circulo(int radioInicial)//el constructor por defecto desaparece, así que hay que escribirlo a manito
        {
            radio = radioInicial;
            NumCirculo++;//no lleva "this" porque no pertenece a un objeto
        }
        public Circulo Clonar()//método de clon, es de tipo "Circulo", por lo tanto ese es el tipo de dato de dato que debe devolver
        {
            //se cre un objeto tipo Circulo
            Circulo clon = new Circulo();

            //se copia el campo privado usando this
            clon.radio = this.radio;

            //retornar el objeto de tipo Circulo que contiene el campo copiado
            return clon;

            //esto sirve si todos los campos son variables de valor, pero no si son variables de 
            //referencia, en ese caso esos campos también debe proporcionar un método de clon

            //al declarar un campo como privado, cada objeto tiene sus datos
            //al ser estático los objetos comparten los mismos datos
        }
        public double Area()//identidicadores públicos empiezan con mayúscula
        {
            return Math.PI * this.radio * this.radio;
        }

        public int CompareTo(Circulo otro)
        {
            Circulo circObj = (Circulo)otro; //se recibe un objeto así que se castea
   
            if (this.Area() == circObj.Area())
                return 0;
            if (this.Area() > circObj.Area())
                return 1;
            return -1;
        }
    }
    partial class Circulo
    {
        const int algo = 1;//los const pueden ser int, double, string y enumeraciones(?)
        //las constantes son estáticas(eso dice e libro pero a mí no me resulta)
    }
}
