using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    internal class Service
    {
        private static void Swap(double[] swapArray, int indexA, int indexB)
        {
            double tempSwap = swapArray[indexA];
            swapArray[indexA] = swapArray[indexB];
            swapArray[indexB] = tempSwap;
        }

        public static void arraySort(double[] sortArray)
        {
            int left = 0;
            int right = sortArray.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        Swap(sortArray, i, i + 1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    if (sortArray[i - 1] > sortArray[i])
                    {
                        Swap(sortArray, i, i - 1);
                    }
                }
                left++;
            }
        }

        public static double arraySum(double[] sumArray)
        {
            double result = 0;
            foreach (var item in sumArray)
            {
                result += item;
            }

            return result;
        }
    }
}
