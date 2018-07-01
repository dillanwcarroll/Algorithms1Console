using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Algorithms1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvReader = new CSVreader(); 
            var mySearch = new MySearch(); //Linear and Binary, Binary should only sort sorted data
            var mySort = new MySort(); //Insert and Shell

            string path = "C:/Users/New/Documents/visual studio 2017/Projects/Algorithms1Console/unsorted_numbers.csv";

            int[] data = csvReader.ReadFile(path); // comment out unnecessary stuff

            int[] sorted = mySort.InsertionSort(data);

            Console.WriteLine("Linear Search");
            var linearstopwatch = Stopwatch.StartNew();
            mySearch.LinearSearchHighest(data);
            linearstopwatch.Stop();
            Console.WriteLine("Linear Search: " + ((linearstopwatch.Elapsed.TotalMilliseconds).ToString()));

            Console.WriteLine();

            //Console.WriteLine("Binary Search");
            //var binarystopwatch = Stopwatch.StartNew();
            //mySearch.LinearSearchHighest(data);
            //binarystopwatch.Stop();
            //Console.WriteLine("Binary Search: " + ((binarystopwatch.Elapsed.TotalMilliseconds).ToString()));

            //Console.WriteLine();

            Console.WriteLine("Linear 1500th Search");
            var linear1500thstopwatch = Stopwatch.StartNew();
            mySearch.LinearSearchEvery1500th(sorted);
            linear1500thstopwatch.Stop();
            Console.WriteLine("Linear 1500th Search: " + ((linear1500thstopwatch.Elapsed.TotalMilliseconds).ToString()));

            Console.WriteLine();

            //Console.WriteLine("Binary 1500th Search");
            //var binary1500thstopwatch = Stopwatch.StartNew();
            //mySearch.BinarySearchEvery1500th(sorted);
            //binary1500thstopwatch.Stop();
            //Console.WriteLine("Binary 1500th Search: " + ((binary1500thstopwatch.Elapsed.TotalMilliseconds).ToString()));

            Console.ReadKey();


        }
    }
}
