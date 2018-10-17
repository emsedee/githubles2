using System;

namespace gitapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 548962134;
            int b = 478951346;
            Console.WriteLine(a + b);
            int c = 314679851;
            int d = 255555;
            Console.WriteLine(c - d);
            int e = 5678;
            int k = 25556;
            Console.WriteLine(e * k);
            int f = 100;
            int penis = 10;
            Console.WriteLine(f / penis);
            // test
            // test 2
        }

        public static int GetNthFibonacci_Ite(int n)

        {

            int number = n - 1;

            int[] Fib = new int[number + 1];

            Fib[0] = 0;

            Fib[1] = 1;



            for (int i = 2; i <= number; i++)

            {

                Fib[i] = Fib[i - 2] + Fib[i - 1];

            }

            return Fib[number];

        }
    }
}
