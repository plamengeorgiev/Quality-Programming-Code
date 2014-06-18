using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopRefactoring
{
    internal class ForLoopRefactoring
    {
        private static void PrintElementsUntilIndexAndValueAreFound(int[] array, Predicate<int> indexPredicate, int value)
        {
            int arrayLength = array.Length;

            for (int index = 0; index < arrayLength; index++)
            {
                Console.WriteLine(array[index]);

                if (indexPredicate(index) && array[index] == value)
                {
                    break;
                }
            }
        }

        private static void Main()
        {
            int value = 666;

            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            PrintElementsUntilIndexAndValueAreFound(array, i => i % 10 == 0, value);
        }
    }
}
