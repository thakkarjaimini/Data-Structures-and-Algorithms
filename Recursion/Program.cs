using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            ToBinary(49);
            Console.WriteLine();
            ConverttoBase(49, 2);
            Console.WriteLine();
            ConverttoBase(49, 8);
            Console.WriteLine();
            ConverttoBase(49, 16);
            Console.WriteLine();
            Console.ReadLine();

        }
        public static void ConverttoBase(int n, int b)
        {
            if (n == 0)
                return;
            ConverttoBase(n / b, b);

            int remainder = n % b;
            if (remainder < 10)
                Console.WriteLine(remainder);
            else
                Console.Write((char)(remainder - 10 + 'A'));
        }
        public static void ToBinary(int n)
        {
            if (n == 0) return;
            ToBinary(n / 2);
            Console.Write(n % 2);                       
        }
   
    }
}
