using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[100];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = 2*i;
            }
            int search = 60;
            int index = BinarySearch(ints, search);
            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] ints, int search)
        {
            int st, dr;
            st = 0;
            dr = ints.Length - 1;
            while(st <= dr)
            {
                int mid = (st + dr) / 2;
                if (ints[mid] == search)
                {
                    return mid; // Found the element
                }
                else if (ints[mid] < search)
                {
                    st = mid + 1; // Search in the right half
                }
                else
                {
                    dr = mid - 1; // Search in the left half
                }
            }
            return -1; // Element not found
        }
    }
}
