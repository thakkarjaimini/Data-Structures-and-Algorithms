using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDepoProgram
{
    class Program
    {
        static int MaxElementIndex(int[] arr, int length)
        {
            int currMax = arr[0];
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > currMax)
                {
                    currMax = arr[i];
                    index = i;
                }
            }
            return index;
        }
        static void Flip(int[] flipArray, int flipLength) {

            int left = 0;
            while (left  < flipLength)
            {
                // exchange the left and right elements
                int temp = flipArray[left];
                flipArray[left] = flipArray[flipLength];
                flipArray[flipLength] = temp;

                // move the bounds toward the center
                left++;
                flipLength--;
            }


        }

        static void SortPlank(int[] arr, int length)
        {
            for (int i = length - 1; i > 0; i--)
            {
                int index = MaxElementIndex(arr, i);

                Flip(arr, index);
                Flip(arr, i - 1);             
                
            }

            Console.WriteLine(value: "Print the array");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("    " + arr[i] + "   ");

            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 10, 6, 8, -1, 19 };
            int length = arr.Length;
            SortPlank(arr, length);
        }
    }
}