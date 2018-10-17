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
            int Richie = 10;
            Console.WriteLine(f / Richie);

            // Bereid de applicatie uit zodat deze in staat is om makkelijk een berekening te maken


            Console.WriteLine("Geef een getal in");
            int getal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef een getal in");
            int getal = int.Parse(Console.ReadLine());
            Console.WriteLine("Welke bewerking wil je doen?");
            string value = Console.ReadLine();
            int i = int.Parse(System.Console.ReadLine());
            switch (value)
            {
                case "x":
                    Console.Write(getal1 + getal);

                    break;
                case "/":
                    Console.Write(getal1 / getal);

                    break;
                case "*":
                    Console.Write(getal1 * getal);
                    break;
                case "-":
                    Console.Write(getal1 - getal);

                    break;
                default:
                    break;
            }





            int penis = 10;
            Console.WriteLine(f / penis);
            // test
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

