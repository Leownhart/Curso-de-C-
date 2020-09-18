using System;
using System.Globalization;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão  A, B, C.
             * em seguida, calcule e mostre: 
             
             a) a área do triângulo retângulo que tem A por base e C por altura.
             b) a área  do circulo de raio C. (pi = 3.14159)
             c) a área do trpézio que tem A e B por bases e C por altura.
             d) a área do quadrado que tem lado B.
             e) a área do retângulo que tem lados A e B.
             */
           
            double A, B, C;
            double area_trian, area_circ, area_trap, area_quad, area_retan, pi = 3.14159;

            string[] val = Console.ReadLine().Split(' ');
            A = double.Parse(val[0], CultureInfo.InvariantCulture);
            B = double.Parse(val[1], CultureInfo.InvariantCulture);
            C = double.Parse(val[2], CultureInfo.InvariantCulture);

            area_trian = A * C / 2;
            area_circ = pi * Math.Pow(C, 2);
            area_trap = (A + B) * C / 2;
            area_quad = Math.Pow(B, 2);
            area_retan = A * B;

            Console.WriteLine("TRIANGULO " + area_trian.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO " + area_circ.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPAZIO " + area_trap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO " + area_quad.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO " + area_retan.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
