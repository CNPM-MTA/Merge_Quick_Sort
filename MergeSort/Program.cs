using Merge_QuickSort;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_QuickSort
{
    class Program
    {
        private const int MAX = int.MaxValue;
        static void Main(string[] args)
        {
            int n;
            int[] arr;
            //Console.Write("Input n = ");
            //if (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    n = 0;
            //}
            //Console.WriteLine("n =  " + n);


            //MERGE SORT
            arr = new int[] { 4, 3, 1, 5, 2, 7, 9, 10, 12, 50, 1, 0, -3, 55, 2, 8, 12 };
           
            n = arr.Length;
            int left = 0;
            int right = n - 1;
            left = 0;
            Console.WriteLine("\nMerge sort: \n");
            (new Merge_Sort()).MergeSort(arr, left, right);
            for (left = 0; left < n; left++)
                Console.Write("\t" + arr[left]);


            //QUICK SORT
            arr = new int[] { 3, 5, 8, 9, 4, 2, 7, 5, 3, 9, 8 };
            (new Quick_Sort()).QuickSort(arr, 0, arr.Length - 1);
            int i;
            Console.WriteLine("\nQuick sort: \n");
            for (i= 0; i< arr.Length- 1; i++)
            {
                Console.Write("\t " + arr[i]);
            }
            Console.ReadKey();
        }

        public static int[] ReadFile(string fileName, int number)
        {
            int[] result = new int[number];
            String input = File.ReadAllText(fileName);
            StreamReader reader = new StreamReader(fileName);
            int i = 0;
            int temp;
            string read;
            do
            {
                if((read=reader.ReadLine()) != null)
                {
                    if(!int.TryParse(read, out temp))
                    {
                        result[i] = temp;
                    }
                }
                i++;
            } while (i < number);
            return result;
        }
    }
}
