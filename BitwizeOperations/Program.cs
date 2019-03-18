using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwizeOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 3;
            x ^= y;
            y ^= x;
            x ^= y;
            Console.WriteLine("x=" + x + " y="+y);
            bool haveSameSign = 0 <= (x ^ y);
            /*Console.WriteLine(Multiply(1, 1));
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Multiply(10, 3));
            Console.WriteLine(Sub(1, 1));
            Console.WriteLine(Sub(1, 2));
            Console.WriteLine(Sub(2, 2));
            Console.WriteLine(Sub(10, 1));
            Console.WriteLine(Add(1, 1));
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Add(10, 1));*/
        }
        static int Add(int a, int b)
        {
            while (b != 0)
            {
                int c = a & b;
                a = a ^ b;
                b = c << 1;
            }
            return a;
        }
        static int Sub(int a, int b)
        {
            while (b != 0)
            {
                int borrow = (~a) & b;
                a = a ^ b;
                b = borrow << 1;
            }
            return a;
        }
        static int Multiply(int n, int m)
        {
            int answer = 0;
            int count = 0;
            while (m != 0)
            {
                if (m % 2 == 1)
                    answer += n << count;
                count++;
                m /= 2;
            }
            return answer;
        }
    }
}
