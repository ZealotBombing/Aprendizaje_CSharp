using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class LosStructs
    {
        
        //Esta clase la hice para trabajar con el struct en un fichero nuevo
        //varios operadores no se pueden usar con los struct
        //no se puede usar == o != pero sí Equals()
        //es nullable

        private Tiempo tiempo;//se declara y se usa como cualquier tipo de valor
        //también es nulable
        private Tiempo? tiempo1;

        public void Metodo(Tiempo parametro)
        {
            Tiempo variableLocal;
            Tiempo t = new Tiempo();//se puede o no llamar a un constructor
            //si se usa sin constructor los campos no se inician, resultando en un error
            Tiempo now = new Tiempo(12, 30,5);//se puede usar el constructor hecho por el programador
        }
    }
    struct Tiempo
    {
        private int horas, minutos, segundos;//los campos no se pueden iniciar

        public Tiempo(int hh, int mm, int ss)//no se puede declarar un constructor sin parámetros
        {//siempre habá un constructor por defecto se escriba o no y no puede haber dos constructores
            
            this.horas = hh % 24;
            this.minutos = mm % 60;
            this.segundos = ss % 60;
            //se debe inicializar todos los campos de un struct
        }

        //para los datos más complejos se usan clases ya que copiar datos es menos eficiente
        //se usan struct cuando su característica principal es el valor y no la funcionalidad
        public int Hours()
        {
            return this.horas;
        }
    }
    //ejercicio Práctico
    struct Fecha
    {
        private int year;
        private Mes month;//se usa el enum que se creó anteriormente
        private int day;
        public Fecha(int ccyy, Mes mm,int dd)
        {
            this.year = ccyy - 1900;
            this.month = mm;
            this.day = dd - 1;
        }
        public override string ToString()
        {
            string data = $"{this.month} {this.day + 1} {this.year + 1900}";
            return data;
        }
        public void AvanzarMes()//este método es para avanzar un mes
        {
            this.month++;
            if (this.month==Mes.Diciembre+1)//se evalua si es el último mes
            {
                this.month = Mes.Enero;//se reinicia el mes
                this.year++;//se avanza un año
            }
        }
    }
}
