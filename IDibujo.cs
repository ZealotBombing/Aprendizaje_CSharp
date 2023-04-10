using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepositorioCentral
{
    //ejercicio del libro
    interface IDibujo
    {
        void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
    interface IColor
    {
        void SerColor(Color color);
    }
    class Cuadrado : IDibujo, IColor
    {
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle? rect = null;

        public Cuadrado(int sideLength)
        {
            this.sideLength = sideLength;
        }

        void IDibujo.Draw(Canvas canvas)
        {
            throw new NotImplementedException();
        }

        void IColor.SerColor(Color color)
        {
            throw new NotImplementedException();
        }

        void IDibujo.SetLocation(int xCoord, int yCoord)
        {
            throw new NotImplementedException();
        }
        //No puedo seguir con este ejercicio
    }
}
