using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }
        public int size()
        {
            int s = 0;
            Node p = top;
            while (p != null) {
                p = p.link;
                s++;
            }
            return s;
        }
        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException();
            }
            x = top.info;
            top = top.link;
            return x;
        }
        public int Peek()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException();
            }
            return top.info;
        }
        public bool IsEmpty()
        {
        return top == null;}
        public void Display()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException();
            }
            Node p = top;
            while(p != null){
                Console.WriteLine(p.info);
                p = p.link;
            }
            Console.WriteLine();             

        }
    }
}
