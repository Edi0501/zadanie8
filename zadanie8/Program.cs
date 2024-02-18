using System;
namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wyniki testu z matematyki, chemii i fizyki");
            Console.WriteLine("Matematyka:");
            int a = 25;
            int b = 63;
            int c = 79;

            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Fizyka:");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Chemia:");
            Int32.TryParse(Console.ReadLine(), out c);
            if (a + b + c >= 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (a + b >= 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (a + c >= 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }

            else
            {
                Console.WriteLine("Przykro mi, masz za mało punktów.");
            }
        }
    }
}

