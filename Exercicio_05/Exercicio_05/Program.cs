using System;
using System.Globalization;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler o código de uma peça, o número de peças 1, o valor unitário de cada peça 1,
             * o código de uma peça 2, onúmero de peças 2 e ovalor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/

            int cod_p1, cod_p2, num_p1, num_p2;
            float val_un_p1, val_un_p2, val_apagar;

            string[] val = Console.ReadLine().Split(' ');
            cod_p1 = int.Parse(val[0]);
            num_p1 = int.Parse(val[1]);
            val_un_p1 = float.Parse(val[2], CultureInfo.InvariantCulture);

            val = Console.ReadLine().Split(' ');
            cod_p2 = int.Parse(val[0]);
            num_p2 = int.Parse(val[1]);
            val_un_p2 = float.Parse(val[2], CultureInfo.InvariantCulture);

            val_apagar = (val_un_p1 * num_p1) + (val_un_p2 * num_p2);

            Console.WriteLine("VALOR A PAGAR : R$" + val_apagar.ToString("F2"));
        }
    }
}
