using System;

namespace even_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //*1.Write a program checking if a number given by the user is even or odd.
            int n1;

            Console.WriteLine("Write a number odd or even: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine($"{n1} is even number");
            }
            else
            {
                Console.WriteLine($"{n1} is odd number");
            }
        }
    }
}
