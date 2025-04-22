using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = int.Parse(Console.ReadLine());
            if (fact == 1 || fact == 0)
                Console.WriteLine("1");
            else
            {

                foreach (var a in Factorial(fact))
                    Console.Write(a);
            }
            Console.ReadLine();




        }

        public static int[] Mult(int[] arr1, int n)
        {
            int[] res = new int[arr1.Length + 10]; 
            arr1 = arr1.Reverse().ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                res[i] += arr1[i] * n;
            }

            
            for (int i = 0; i < res.Length - 1; i++)
            {
                if (res[i] >= 10)
                {
                    res[i + 1] += res[i] / 10;
                    res[i] %= 10;
                }
            }

            
            int lastIndex = res.Length - 1;
            while (lastIndex > 0 && res[lastIndex] == 0)
                lastIndex--;

            int[] finalRes = new int[lastIndex + 1];
            for (int i = 0; i <= lastIndex; i++)
                finalRes[i] = res[i];

            return finalRes.Reverse().ToArray();

        }
        public static List<int> Factorial(int n)
        {
            List<int> res = new List<int>();
            res.Add(1);
            for(int i = 2; i <= n; i++)
            {
                res = Mult(res.ToArray<int>(),i).ToList();
            }
            return res;
        }
    }
}
