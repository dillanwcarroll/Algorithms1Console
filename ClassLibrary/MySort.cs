using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MySort
    {
        public int[] InsertionSort(int[] intArray)
        {
            int temp, j;

            for (int i = 1; i < intArray.Length; i++)
            {
                temp = intArray[i];

                j = i - 1;

                while (j >= 0 && intArray[j] > temp)

                {
                    intArray[j + 1] = intArray[j];
                    j--;
                }
                intArray[j + 1] = temp;
            }

            //string[] sorted = intArray.Select(x => x.ToString()).ToArray();

            return intArray;
        }

        public int[] ShellSort(int[] data)
        {
            int n = data.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = data[j];

                    while (j - gap >= 0 && temp < data[j - gap])
                    {
                        data[j] = data[j - gap];
                        j = j - gap;
                    }

                    data[j] = temp;
                }

                gap = gap / 2;
            }

            //string[] sorted = data.Select(x => x.ToString()).ToArray();

            return data;
        }
    }
}