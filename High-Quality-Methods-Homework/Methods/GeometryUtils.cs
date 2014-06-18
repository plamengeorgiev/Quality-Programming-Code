using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class GeometryUtils
    {
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return distance;
        }

        public static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            return y1 == y2;
        }

        public static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            return x1 == x2;
        }

        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("The lengths of the sides shoud be a positive numbers");
            }
            else if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("The entered sides cannot form a triangle");
            }
            else
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                return area;
            }
        }
    }
}
