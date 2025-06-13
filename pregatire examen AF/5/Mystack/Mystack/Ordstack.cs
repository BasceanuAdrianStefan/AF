using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystack
{
    internal class Ordstack
    {
        public int[] stack;
        public int capacity;
        public Ordstack()
        {
            stack = null;
            capacity = 0;
        }
        public void Add(int value)
        {
            if (stack == null)
            {
                stack = new int[4];
                capacity = 4;
            }
            else if (capacity == stack.Length)
            {
                Resize();
            }
            stack[capacity++] = value;
            Array.Sort(stack, 0, capacity);
        }
        public void Pop()
        {
            if (stack == null || capacity == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int[] newstack = new int[capacity - 1];
            for (int i = 0; i < capacity - 1; i++)
            {
                newstack[i] = stack[i];
            }
            stack = newstack;

        }
        
        private void Resize()
        {
            int[] newstack = new int[capacity + 1];
            for (int i = 0; i < capacity; i++)
            {
                newstack[i] = stack[i];
            }
            stack = newstack;
            capacity = newstack.Length;
        }

    }
    
}
