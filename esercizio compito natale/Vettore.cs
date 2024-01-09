using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_compito_natale
{
    internal class Vettore
    {
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public void Somma(Vettore vettore)
        {
            X += vettore.X;
            Y += vettore.Y;
        }
    }
}
