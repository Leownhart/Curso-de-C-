using System;
using System.Globalization;
namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe
             * por hora e calcular o salário desse funcionário, A seguir, mostre o número e o slário do funcionário, com duas casas.*/

            int Hora_Tra, Num_Fun;
            float Valor_Ph, Sal_Fun;

            Console.WriteLine("Informe o número do funcionario: ");
            Num_Fun = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o número de horas trabalhadas: ");
            Hora_Tra = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor por hora trabalhada: ");
            Valor_Ph = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Sal_Fun = Valor_Ph * Hora_Tra;

            Console.WriteLine("NUMERO: " + Num_Fun);
            Console.WriteLine("SALÁRIO " + Sal_Fun.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
