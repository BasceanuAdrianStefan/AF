using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToH4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TofHanoi4(4,'A', 'D', 'B', 'C');
        }

        private static void TofHanoi4(int n, char source, char target, char aux1, char aux2)
        {
            if (n == 0) return;

            if (n == 1)
            {
                Console.WriteLine($"{source} -> {target}");
                return;
            }

            if (n == 2)
            {
                Console.WriteLine($"{source} -> {aux1}");
                Console.WriteLine($"{source} -> {target}");
                Console.WriteLine($"{aux1} -> {target}");
                return;
            }

            TofHanoi4(n - 2, source, aux2, aux1, target);
            Console.WriteLine($"{source} -> {aux1}");
            Console.WriteLine($"{source} -> {target}");
            Console.WriteLine($"{aux1} -> {target}");
            TofHanoi4(n - 2, aux2, target, aux1, source);



        }
       
    }
}
