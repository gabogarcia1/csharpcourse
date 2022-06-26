using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Models
{
    public abstract class Cuadrilatero
    {
        private decimal _leftSide;
        private decimal _rightSide;
        private decimal _topSide;
        private decimal _bottomSide;

        public decimal LeftSide { get { return _leftSide; } set { _leftSide = value; } }
        public decimal RightSide { get { return _rightSide; } set { _rightSide = value;} }
        public decimal TopSide { get { return _topSide; } set { _topSide = value; } }
        public decimal BottomSide { get { return _bottomSide; } set { _bottomSide = value;} }

        public abstract void CalculateArea();

    }
}
