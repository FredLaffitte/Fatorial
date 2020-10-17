using System;
using MathNet.Numerics;

namespace Fatorial
{
    class Program
    {
        // Método calculador do fatorial.
        static long Fatorial(int number)
        {
            // Se o parâmetro (valor desejado para calculo do fatorial)
            // for 0 ou 1, o retorno sempre será 1 (devido a regra do fatorial).
            // Se for maior que 1, é feito o número vezes o fatorial desse mesmo número menos 1
            // até o parâmetro ser 1.
            // Isso é chamado de função recursiva / método recursivo / recursive function.
            if (number <= 1)
                return 1;
            else return number * Fatorial(number - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("==========Calcular o fatorial de um número===========");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Digite um número de 1 a 10:");
            int num = Int32.Parse(Console.ReadLine());
            int fact = num;

            if (num != 0)
            {
                
                for (int i = num - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
           }
            Console.WriteLine("=====================================================");
            Console.WriteLine("===================Cálculo direto====================");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Fatorial de " + num + " = " + fact.ToString("N"));
            Console.WriteLine("=====================================================");
            Console.WriteLine("=====Cálculo utilizando biblioteca/pacote nuget======");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Fatorial de {num} = {SpecialFunctions.Factorial(num).ToString("N")}");
            Console.WriteLine("=====================================================");
            Console.WriteLine("=========================FIM=========================");
            Console.WriteLine("=====================================================");
            // Aguarda para sair.
            Console.ReadLine();

        }
    }
}
