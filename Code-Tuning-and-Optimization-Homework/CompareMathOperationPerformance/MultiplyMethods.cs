﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMathOperationPerformance
{
    class MultiplyMethods
    {
        public static void MultiplyInt(int startValue, int endValue, int step)
        {
            for (int i = startValue; i <= endValue; )
            {
                i = i * step;
            }
        }
        public static void MultiplyLong(long startValue, long endValue, long step)
        {
            for (long i = startValue; i <= endValue; )
            {
                i = i * step;
            }
        }
        public static void MultiplyFloat(float startValue, float endValue, float step)
        {
            for (float i = startValue; i <= endValue; )
            {
                i = i * step;
            }
        }
        public static void MultiplyDouble(double startValue, double endValue, double step)
        {
            for (double i = startValue; i <= endValue; )
            {
                i = i * step;
            }
        }
        public static void MultiplyDecimal(decimal startValue, decimal endValue, decimal step)
        {
            for (decimal i = startValue; i <= endValue; )
            {
                i = i * step;
            }
        }
    }
}
