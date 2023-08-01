using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLinearSearch
{
    internal class Program
    {
        public static int LinearSearch(int[] arr, int Sitem)
        {
            int index = -1;
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] == Sitem)
                {
                    return i;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 20, 5, 15 };
            Console.WriteLine("Please Enter the Number you want to Enter");
            int Sitem = int.Parse(Console.ReadLine());
            int result = LinearSearch(arr, Sitem);
            if (result != -1)
            {
                Console.WriteLine($"{Sitem} found at Index {result}");
            }
            else
            {
                    Console.WriteLine($"{Sitem} not Found");
            }
            Console.ReadKey();
        }
    }
}
