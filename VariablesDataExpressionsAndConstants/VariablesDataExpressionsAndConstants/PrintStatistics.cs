using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesDataExpressionsAndConstants
{
    class PrintStatistics
    {
        public void PrintStatistics(double[] arr, int count)
        {
            double max = Int64.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            PrintMax(max);
            double min = Int64.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            PrintMin(max);

            double sumOfElements = 0;
            for (int i = 0; i < count; i++)
            {
                sumOfElements += arr[i];
            }
            PrintAverage(sumOfElements / count);
        }

        private void PrintAverage(double value)
        {
            throw new NotImplementedException();
        }

        private void PrintMin(double value)
        {
            throw new NotImplementedException();
        }

        private void PrintMax(double value)
        {
            throw new NotImplementedException();
        }
    }
}
