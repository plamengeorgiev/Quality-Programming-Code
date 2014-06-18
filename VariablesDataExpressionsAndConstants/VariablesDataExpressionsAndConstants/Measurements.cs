using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataExpressionsAndConstants
{
    public class Measurements
    {
        private double width;
        private double height;
        public Measurements(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public static Measurements GetRotatedSize(Measurements currentFigure, double angleOfRotation)
        {
            return new Measurements(
              Math.Abs(Math.Cos(angleOfRotation)) * currentFigure.width + Math.Abs(Math.Sin(angleOfRotation)) * currentFigure.height,
              Math.Abs(Math.Sin(angleOfRotation)) * currentFigure.width + Math.Abs(Math.Cos(angleOfRotation)) * currentFigure.height);
        }
    }
}
