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
            int temp, t;

            for (int n = 1; n < intArray.Length; n++)
            {
                temp = intArray[i];

                t = n - 1;

                while (t >= 0 && intArray[t] > temp)

                {
                    intArray[t + 1] = intArray[t];
                    t--;
                }
                intArray[t + 1] = temp;
            }
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
            return data;
        }
    }
}