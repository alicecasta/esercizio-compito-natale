using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_compito_natale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore vettore1 = new Vettore(2, 2);
            Vettore vettore2= new Vettore(3,3);
          // Vettore vettore3= new Vettore();
           // vettore3 = Vettore.Prase("4; 4");

            //somma tra il vettore 1 e 2
            vettore1.Somma(vettore2);
            

        }
    }
}
