using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Square : IShape
    {
        double side = 0;
        public void SetInput(double side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            if (!(IsNegetive()))
                return side * side;
            else
                return 0;
        }
        public bool IsNegetive()
        {
            if (side < 0)
                return true;
            else
                return false;
        }
    }
}
