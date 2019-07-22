using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : IShape
    {
        double radius = 0;
        public void SetInput(double radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            if (!(IsNegetive()))
                return 3.14 * radius * radius;
            else
                return 0;
        }

        public bool IsNegetive()
        {
            if (radius < 0)
                return true;
            else
                return false;
        }
    }
}
