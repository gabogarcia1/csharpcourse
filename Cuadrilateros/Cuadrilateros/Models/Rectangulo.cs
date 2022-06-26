using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Models
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo()
        {
            Console.WriteLine("Usted esta ingresando un Rectangulo, por favor elija el tamanio de los lados en cm");
            Console.WriteLine("Lado Izquierdo: ");
            LeftSide = decimal.Parse(Console.ReadLine());

            RightSide = LeftSide;
            Console.WriteLine("Lado Superior: ");
            TopSide = decimal.Parse(Console.ReadLine());

            BottomSide = TopSide;
        }

        public override void CalculateArea()
        {
            var area = (RightSide * BottomSide);
            Console.WriteLine($"El area del rectangulo es {area} cm2");
        }
    }
}
