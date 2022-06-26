using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Models
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio()
        {
            Console.WriteLine("Usted esta ingresando un trapedio, por favor elija el tamanio de los lados");
            Console.WriteLine("Lado Izquierdo: ");
            LeftSide =  decimal.Parse(Console.ReadLine());
            Console.WriteLine("Lado Derecho: ");
            RightSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Lado Superior: ");
            TopSide = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Lado Inferior: ");
            BottomSide = decimal.Parse(Console.ReadLine());
        }

        public override void CalculateArea() 
        {
            decimal h = 0;
            decimal x = 0;
            decimal s = TopSide>BottomSide ? TopSide-BottomSide : BottomSide-TopSide;
            decimal auxLeft = (decimal) Math.Pow(Convert.ToDouble(LeftSide),2);
            decimal auxRight = (decimal)Math.Pow(Convert.ToDouble(RightSide), 2);

            x = (decimal)Math.Pow(Convert.ToDouble(s),2);
            x = auxRight - x;
            x = (auxLeft - x) / (2 * s);

            h= (decimal) Math.Sqrt(Convert.ToDouble(auxLeft - (decimal)Math.Pow(Convert.ToDouble(x),2)));


            var area = (TopSide + BottomSide)*h/2;
            Console.WriteLine($"El altura del trapecio es {h}");
            Console.WriteLine($"El area del trapecio es {area}");
        }
    }
}
