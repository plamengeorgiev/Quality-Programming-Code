using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CompareMathOperationPerformance
{
    class TestPerformance
    {
        static void Main()
        {
            Console.WriteLine("Addition:");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            AddMethods.AddDecimal(4m, 500000m);
            stopwatch.Stop();
            Console.WriteLine("Decimal numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            AddMethods.AddDouble(4d, 500000d);
            stopwatch.Stop();
            Console.WriteLine("Double numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            AddMethods.AddFloat(4f, 500000f);
            stopwatch.Stop();
            Console.WriteLine("Float numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            AddMethods.AddInt(4, 500000);
            stopwatch.Stop();
            Console.WriteLine("Int numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            AddMethods.AddLong(4L, 500000L);
            stopwatch.Stop();
            Console.WriteLine("Long numbers: {0}", stopwatch.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Substraction:");
            stopwatch.Restart();
            SubstractMethods.SubstractDecimal(500000m, 4m);
            stopwatch.Stop();
            Console.WriteLine("Decimal numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            SubstractMethods.SubstractDouble(500000d, 4d);
            stopwatch.Stop();
            Console.WriteLine("Double numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            SubstractMethods.SubstractFloat(500000f, 4f);
            stopwatch.Stop();
            Console.WriteLine("Float numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            SubstractMethods.SubstractInt(500000, 4);
            stopwatch.Stop();
            Console.WriteLine("Int numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            SubstractMethods.SubstractLong(500000L, 4L);
            stopwatch.Stop();
            Console.WriteLine("Long numbers: {0}", stopwatch.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Multiplication:");
            stopwatch.Restart();
            MultiplyMethods.MultiplyDecimal(2m, 500000m, 2m);
            stopwatch.Stop();
            Console.WriteLine("Decimal numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            MultiplyMethods.MultiplyDouble(2d, 500000d, 5d);
            stopwatch.Stop();
            Console.WriteLine("Double numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            MultiplyMethods.MultiplyFloat(2f, 500000f, 5f);
            stopwatch.Stop();
            Console.WriteLine("Float numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            MultiplyMethods.MultiplyInt(2, 500000, 5);
            stopwatch.Stop();
            Console.WriteLine("Int numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            MultiplyMethods.MultiplyLong(2L, 500000L, 5L);
            stopwatch.Stop();
            Console.WriteLine("Long numbers: {0}", stopwatch.Elapsed);
            Console.WriteLine();

            Console.WriteLine("Division:");
            stopwatch.Restart();
            DivideMethods.DivideDecimal(500000m, 4m, 2m);
            stopwatch.Stop();
            Console.WriteLine("Decimal numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            DivideMethods.DivideDouble(500000d, 4d, 2d);
            stopwatch.Stop();
            Console.WriteLine("Double numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            DivideMethods.DivideFloat(500000f, 4f, 2f);
            stopwatch.Stop();
            Console.WriteLine("Float numbers: {0}", stopwatch.Elapsed);
            stopwatch.Start();
            DivideMethods.DivideInt(500000, 4, 2);
            stopwatch.Stop();
            Console.WriteLine("Int numbers: {0}", stopwatch.Elapsed);
            stopwatch.Restart();
            DivideMethods.DivideLong(500000L, 4L, 2L);
            stopwatch.Stop();
            Console.WriteLine("Long numbers: {0}", stopwatch.Elapsed);
            Console.WriteLine();
        }
    }
}
