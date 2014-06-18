using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathUtils
    {

        public static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The array of elements cannot be null");
            }
            else if (elements.Length == 0)
            {
                throw new ArgumentException("The array of elements is empty");
            }
            int maxValue = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxValue)
                {
                    maxValue = elements[i];
                }
            }
            return maxValue;
        }
    }
}
