using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = r.Next(10000);
            }
            MergeSort(ints, 0, ints.Length - 1);
            for(int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i]+ " ");
            }

        }

        private static void MergeSort(int[] ints, int st, int dr)
        {
            
        }
    }
}
