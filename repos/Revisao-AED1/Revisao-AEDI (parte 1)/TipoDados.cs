using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_dados
{
    class TipoDados
    {
        public static void MostrarTiposDados()
        {
            Console.WriteLine("Mostrando os tipos de dados de C#");
            Console.WriteLine("");

            // Tipos numéricos inteiros
            byte byteVar = 255;             // 8 bits
            sbyte sbyteVar = -128;          // 8 bits com sinal
            short shortVar = -32768;        // 16 bits
            ushort ushortVar = 65535;       // 16 bits sem sinal
            int intVar = -2147483648;       // 32 bits
            uint uintVar = 4294967295;      // 32 bits sem sinal
            long longVar = -9223372036854775808;  // 64 bits
            ulong ulongVar = 18446744073709551615; // 64 bits sem sinal

            // Tipos numéricos de ponto flutuante
            float floatVar = 3.14f;         // 32 bits
            double doubleVar = 3.141592653589793; // 64 bits
            decimal decimalVar = 3.141592653589793238462643383279m; // 128 bits

            // Tipo booleano
            bool boolVar = true;            // Pode ser true ou false

            // Tipo caractere
            char charVar = 'A';             // 16 bits

            // Tipo string (sequência de caracteres)
            string stringVar = "Olá, Mundo!";  // Referência de cadeia de caracteres

            // Tipos de referência
            object objectVar = 12345;        // Pode armazenar qualquer tipo de dado


            // Chamando o método genérico para imprimir variáveis e seus tipos
            PrintVariable(byteVar);
            PrintVariable(sbyteVar);
            PrintVariable(shortVar);
            PrintVariable(ushortVar);
            PrintVariable(intVar);
            PrintVariable(uintVar);
            PrintVariable(longVar);
            PrintVariable(ulongVar);
            PrintVariable(floatVar);
            PrintVariable(doubleVar);
            PrintVariable(decimalVar);
            PrintVariable(boolVar);
            PrintVariable(charVar);
            PrintVariable(stringVar);
            PrintVariable(objectVar);

        }
    
        private static void PrintVariable<T>(T variable)
        {
            Console.WriteLine($"Valor: {variable}, Tipo: {variable!.GetType()}");
        }

    }
}
