using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_alogorithms
{

    class Program
    {
        public static int[] Aglobal = new int[3];

        static void Main(string[] args)
        {

            //int choice, data, k, x;
            //SingleLinkedlist list = new SingleLinkedlist();

            //list.CreateLinkedlist();
            //list.DisplayList();
            //list.CountNodes();
            //list.Search(8);
            //Console.ReadLine();

            //list.InsertBefore(44, 3);
            //list.DisplayList();
            //list.InsertatPosition(88, 3);
            //list.DisplayList();
            //Console.ReadLine();
            //  while (true)
            //Program obj = new Program();
            //int[] Alocal = new int[3];
            //foreach (int val in Aglobal)
            //{
            //    Console.WriteLine(val);
            //}
            //foreach (int val in Alocal)
            //{
            //    Console.WriteLine(val);
            //}
            //Console.ReadLine();
            int choiceStack, x;
            Stack theStack = new Stack(10);

            while (true)
            {
                Console.WriteLine("1 -Push an element on the stack");
                Console.WriteLine("2- Pop an element from the stack");
                Console.WriteLine("3 - Display all elements of the stack");
                Console.WriteLine("4 - Display the top element of the stack.");
                Console.WriteLine("5 - Display size of the stack.");
                Console.WriteLine("6 - Quit");
                Console.WriteLine("Enter your choice");
                choiceStack = Convert.ToInt32(Console.ReadLine());
                if (choiceStack == 6) break;
                switch (choiceStack)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be pushed");
                        x = Convert.ToInt32(Console.ReadLine());
                        theStack.push(x);
                        break;
                    case 2:
                        x = theStack.pop();
                        Console.WriteLine("Popped element is" + x);
                        break;
                    case 3:
                        theStack.Display();
                        break;
                    case 4:
                        Console.WriteLine("Element at the top is" + theStack.peak());
                        break;
                    case 5:
                        Console.WriteLine("Size of stack is" + theStack.size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("");
            }

            theStack.push(10);
            theStack.push(20);
            theStack.push(30);
            theStack.push(40);
            theStack.push(50);
            theStack.push(60);
            theStack.push(70);

            //while (!theStack.isEmpty())
            //{
            //    long value = theStack.pop();
            //    Console.WriteLine(value);
            //}
            //Console.ReadLine();
        }


    }
}
