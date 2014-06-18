using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class PrintUtils
    {
        public static string PrintNumberAsFixedPointNumber(double number)
        {
            return String.Format("{0:f2}", number);
        }

        public static string PrintNumberAsPercent(double number)
        {
            return String.Format("{0:p0}", number);
        }

        public static string PrintNumberAligned(double number)
        {
            return String.Format("{0,8}", number);
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }
            throw new ArgumentException("Invalid number input!");
        }
    }
}
