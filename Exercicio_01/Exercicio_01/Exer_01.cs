using System;

namespace Exercicios_Fix
{
    class Exer_01
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma
             * desses valores com uma mensagem explicativa.*/

            int n1, n2, n3, soma;
            Console.WriteLine("Informe um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número: ");
            n3 = int.Parse(Console.ReadLine());
            soma = (n1 + n2 + n3);

            Console.WriteLine("A soma dos números informados é: ");
            Console.WriteLine(soma);

        }
    }
}
