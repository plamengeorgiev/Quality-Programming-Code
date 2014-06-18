﻿using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Radius cannot be a negative number");
                }
                this.radius = value;
            }
        }

        public Circle()
        {
            this.Radius = 0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
