using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorioCentral
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjeto = 0;
        //este contador debe ser estático porque así funciona con todas las instancias
        //de la clase círculo, de lo contrario cada objeto tendría su propio contador y
        //siempre sería 1
        
        public Punto()
        {
            this.x = -1;
            this.y = -1;
            contadorDeObjeto++;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjeto++;
        }
        public double DistanciaA(Punto otro)
        {
            int xDiff = this.x - otro.x;
            int yDiff = this.y - otro.y;
            double distancia = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distancia;
        }
        public static int ContadorDeObjeto() => contadorDeObjeto;//método getter
    }
}
