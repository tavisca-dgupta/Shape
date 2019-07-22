using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle : IShape
    {
        double height = 0;
        double side1 = 0;
        double baseSide = 0;
        double side2 = 0;
        double side3 = 0;
        public void SetInput(double baseSide, double height)
        {
            this.baseSide = baseSide;
            this.height = height;
        }
        public void SetInput(double side1,double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double CalculateArea()
        {
            if (!(IsNegetive()))
            {
                if (side1!= 0 && side2 !=0 && side3 !=0)
                {
                    if (IsTriangle())
                    {
                        double semiPerimeter = GetSemiPerimeter();
                        return (Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3)));
                    }
                    else
                        return 0;
                }
                else
                    return 0.5 * baseSide * height;
            }
            else
                return 0;
            
        }

        public bool IsNegetive()
        {
            if (height < 0 || side1 < 0)
                return true;
            else if (side2 < 0 || side3 < 0)
                return true;
            else
                return false;
                
        }

        public bool IsTriangle()
        {
            if (((side1 + side2) > side3) && ((side2 + side3) > side1) && ((side1 + side3) > side2))
                return true;
            else
                return false;
        }

        public double GetSemiPerimeter()
        {
            return (side1+side2+side3)/ 2;
        }
    }
}
