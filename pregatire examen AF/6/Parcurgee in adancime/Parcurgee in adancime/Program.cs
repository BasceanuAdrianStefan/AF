using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcurgee_in_adancime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[15, 15];
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            PA(i, j, ints);
            for(int a = 0; a < ints.GetLength(0); a++)
            {
                for(int b = 0; b < ints.GetLength(1); b++)
                {
                    Console.Write(ints[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void PA(int i, int j, int[,] ints)
        {
            if (i < 0 || i >= ints.GetLength(0) || j < 0 || j >= ints.GetLength(1))
            {
                return;
            }
            if (ints[i, j] >= 1)
            {
                return;
            }
            ints[i, j]++; 
            
            PA(i + 1, j, ints); 
            PA(i - 1, j, ints); 
            PA(i, j + 1, ints); 
            PA(i, j - 1, ints); 
        }

    }
}
