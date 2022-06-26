using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Models
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado()
        {
            Console.WriteLine("Usted esta ingresando un Cuadrado, por favor elija el tamanio de los lados en cm");
            Console.WriteLine("Lado ");
            LeftSide = decimal.Parse(Console.ReadLine());
            RightSide = BottomSide = TopSide = LeftSide; 
        }

        public override void CalculateArea()
        {
            var area = (RightSide * BottomSide);
            Console.WriteLine($"El area del Cuadrado es {area} cm2");
        }
    }
}
