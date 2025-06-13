using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecSort
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Random r = new Random();
            int n = 15;
            int[] ints = new int[n];
            for (int i = 0; i < n; i++)
            {
                ints[i] = r.Next(100);
            }
            Console.WriteLine("Unsorted:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(ints[i] + " ");
            }
            recsort(ints, n);
            Console.WriteLine("Sorted:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }

        public static bool Checksorted(bool b, int n, int[] v)
        {
            if (v[n] < v[n + 1])
            {
                if (n == v.Length - 2)
                {
                    return true;
                }
                else
                {
                    return Checksorted(b, n + 1, v);
                }
            }
            else
            {
                return false;
            }
        }
        public static void recsort(int[] v, int n)
        {
            if (n == 1)
            {
                return;
            }
            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int temp = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = temp;
                    }
                }
                if(Checksorted(false, 0, v))
                {
                    return;
                }
                else
                    recsort(v, n - 1);
            }
        }
    }
}
    

