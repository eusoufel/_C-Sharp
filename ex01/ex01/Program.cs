// See https://aka.ms/new-console-template for more information
using System;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;
            Console.WriteLine("Soma = " + soma);
        }
    }
}
