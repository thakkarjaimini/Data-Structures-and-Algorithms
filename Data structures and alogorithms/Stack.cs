using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_alogorithms
{
    class Stack
    {
       
        private int[] stackArray;
        private int top;

        public Stack(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }
        public Stack()
        {
            stackArray = new int[10];
            top = -1;
        }
        public int size()
        {
            return top + 1;
        }
        public bool isFull()
        {
            return (stackArray.Length - 1 == top);
        }
        public void push (int j)
        {
            if (isFull())
            {
                Console.WriteLine("Stack Overflow"); return;
            }
            else {
                top++;
                stackArray[top] = j;
            }
        }
        public int pop()
        {
            if (isEmpty()) {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            int old_top = stackArray[top];
            top--;
            return old_top;
        }
        public int peak()
        {
            if (isEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
        public void Display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty"); return;
            }
            for (int i = top; i>=0; i--)
            {
                Console.WriteLine(stackArray[i] + " ");
                Console.WriteLine("");
            }
        }
        
    }
}
