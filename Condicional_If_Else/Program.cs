using System;

namespace Condicional_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Bom dia");
            if (x < 5)
            {
                Console.WriteLine("Boa Tarde");
            }
            Console.WriteLine("Boa Noite");

            Console.WriteLine("Entre com um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
                Console.WriteLine("Impar!");
        }
    }
}
