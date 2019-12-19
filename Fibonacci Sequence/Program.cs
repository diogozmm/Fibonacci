using System;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Sequência de Fibonacci! -----");
            Console.WriteLine("Digite um número");

            int value = int.Parse(Console.ReadLine());
            int num1 = 1;
            int num2 = 1;
            int nextNum = 0;

            Console.Write("Sua sequência é: ");
            Console.Write(nextNum + ", ");
            Console.Write(num1);
            while (num2 < value)
            {
                nextNum = num1 + num2;
                num1 = num2;
                num2 = nextNum;
                Console.Write(", " + num1);
            }

        }
    }
}
