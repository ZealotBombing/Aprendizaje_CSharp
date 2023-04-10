using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    //Generic
    public interface IComparer<in T>//la palabra "in" dice que puede pasar T como parámetro o cualquier derivado, algo así
    {
        int Compare(T x, T y);
    }
    interface IRestrinccion
    {
        string mostrar();
    }
    class Queue<T>
    {
        public static HashSet<int> campo;
        public static void u()
        {
            campo.Add(1);
        }
        public static void DeclararGenerico()
        {
            Queue<int> q = new Queue<int>();
            Queue<Queue<int>> z = new Queue<Queue<int>>();

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();//Todo se puede acá oie
        }
      
    }
    class ClaseGenericaConRestriccio<T> where T : IRestrinccion,IComparable
    {

    }
    class DeMetodoGenerico
    {
        public static void Intercambiar<T>(ref T primero, ref T segundo)
        {
            T temp = primero;
            primero = segundo;
            segundo = temp;
        }
    }
}
