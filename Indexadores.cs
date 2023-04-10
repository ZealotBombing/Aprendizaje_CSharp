using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Indexadores
    {
        //pag 426 algo sobre los operadores para bits o algo así
        
    }
    struct IntBits
    {
        private int bits;
        public IntBits(int valorBitInicial)
        {
            bits = valorBitInicial;
        }
        public bool this [int index]
        {
            get
            {
                return (bits & (1 << index)) != 0;
            }
            set
            {
                if (value)//Prende el bit si es real, lo apaga si es falso
                {
                    bits |= (1 << index);
                }
                else
                {
                    bits &= ~(1 << index);
                }
                //página 429 puntos a considerar
            }
        }
        //ahora se puede usar este struct como tipo(ejemplo página 430)
    }
    class Empleado
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Departamento
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
        Empleado[] ListaEmpleado;

        public Departamento()
        {
            DepId = 10;
            DepName = "Ventas";
            ListaEmpleado = new Empleado[3]
            {
                new Empleado { Id = 101, EmpName = "Alex", Salary = 50000},
                new Empleado { Id = 102, EmpName = "Brad", Salary = 45000},
                new Empleado { Id = 103, EmpName = "Chris", Salary = 40000}
            };
        }
        public Empleado GetEmpleado(int id)
        {
            foreach(Empleado emp in ListaEmpleado)
            {
                if (id == emp.Id)
                    return emp;
            }
            return null;
        } 
        public Empleado GetEmpleado(string name)
        {
            foreach(Empleado emp in ListaEmpleado)
            {
                if (name == emp.EmpName)
                    return emp;
            }
            return null;
        }
        public Empleado this[int id]
        {
            get
            {
                foreach(Empleado emp in ListaEmpleado)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }
        }
        public Empleado this[string name]
        {
            get
            {
                foreach(Empleado emp in ListaEmpleado)
                {
                    if (name == emp.EmpName)
                        return emp;
                }
                return null;
            }
        }
    }
}
