using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : IShape
    {
        double length = 0;
        double breadth = 0;

        public void SetInput(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            if (!(IsNegetive()))
                return breadth * length;
            else
                return 0;
        }

        public bool IsNegetive()
        {
            if (length < 0 || breadth < 0)
                return true;
            else
                return false;
        }
    }
}
