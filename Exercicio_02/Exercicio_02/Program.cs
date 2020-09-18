using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios_Fix
{
    class Exer_02
    {
        static void Main(string[] args)
        {
            /* Faça um programa  para ler o valor do raio de um circulo, e depois monstrar o valor da área
             * deste com quatro casas decimais conforme exemplos.*/


            double pi = 3.14159;

            Console.WriteLine("Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}