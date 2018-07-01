using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MySearch
    {
        public void LinearSearchHighest(int[] data)
        {
            int highest = data[0];

            for (int n = 0; n < data.Length; n++)
            {
                if (highest < data[n])
                {
                    highest = data[n];
                }
            }

            Console.WriteLine("The highest number is: " + highest);
        }

        public void LinearSearchEvery1500th(int[] data)
        {
            for (int n = 0; n < data.Length; n++)
            {
                if ((n + 1) % 1500 == 0)
                {
                    Console.WriteLine(data[n]);
                }
            }
        }

        public void BinarySearchEvery1500th(int[] data)
        {
            int fir = 0;
            int obj = 1499;
            int lst = data.Length;
            int mid = (lst + fir) / 2;

            if (obj >= fir && obj <= lst)
            {
                if (obj <= mid)
                {
                    while (obj < mid)
                    {
                        if ((obj + 1) % 1500 == 0)
                        {
                            Console.WriteLine(data[obj]);
                        }
                        obj++;
                    }
                }

                if (obj >= mid)
                {
                    while (obj < lst)
                    {
                        if ((obj + 1) % 1500 == 0)
                        {
                            Console.WriteLine(data[obj]);
                        }
                        obj++;
                    }
                }
            }
        }
    }
}
