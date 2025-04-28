using ExemplosFPAA;

class Program
{
    static void Main()
    {
        /* int x = 23;
         Questao01 questao01 = new Questao01();
         int resultado = questao01.PesquisaBinaria(x);

         if (resultado != -1)
             Console.WriteLine($"\nElemento encontrado na posição {resultado}");
         else
             Console.WriteLine("\nElemento não encontrado no vetor");

         */

        int[] elementos = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };

        var unificador = new UnificadorDeListaEstatica(elementos);

        Console.WriteLine("Vetor inicial:");
        unificador.Imprimir();

        int resultado = unificador.Unificar();

        Console.WriteLine("\nResultado final da unificação: " + resultado);
    }

}

