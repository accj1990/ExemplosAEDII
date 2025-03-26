using System;

namespace repeticoes
{
    public class Repeticoes
    {
        protected static int[] Valores { get; set; } = { 1, 2, 3, 4, 5 };

        public static void RepeticaoComForExemplo01()
        {
            Console.WriteLine("Diga olá 10x começando de 0 !!");
            int i = 0;
            for (i = 0; i < 10; i++) // somatorio de i = 0 até n-1 de 1 é n
            {
                Console.WriteLine($"{i} - Olá!");
            }
            Console.WriteLine($"- Atenção Falei {i}");
        }

        public static void RepeticaoComForExemplo02()
        {
            Console.WriteLine("Diga olá 10x começando de 1 !!");
            int i = 0;
            for (i = 1; i <= 10; i++)// somatorio de i = 1 até n de 1 = n-1
            {
                Console.WriteLine($"{i} - Olá!");
            }
            Console.WriteLine($"- Atenção Falei {i - 1}");

        }
    }
}
