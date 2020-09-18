using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa  para ler  quatro valores inteiros  a, b, c, d. A seguir, calcule e mostre a diferença do produto
             * de A e B pelo produto de C e D segundo a fómula: DIFERENÇA = (A * N - C * D).*/ 
             
            Console.WriteLine("Informe um valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o teceiro valor: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quarto valor: ");
            int d = int.Parse(Console.ReadLine());

            int dif = (a * b - c * d);

            Console.WriteLine("A Diferença é " + dif);
        }
    }
}
