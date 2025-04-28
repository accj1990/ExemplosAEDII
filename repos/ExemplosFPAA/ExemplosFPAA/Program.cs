using ExemplosFPAA;

class Program
{
    static void Main()
    {
        int x = 23;
        Questao01 questao01 = new Questao01();
        int resultado = questao01.PesquisaBinaria(x);

        if (resultado != -1)
            Console.WriteLine($"\nElemento encontrado na posição {resultado}");
        else
            Console.WriteLine("\nElemento não encontrado no vetor");
    }

}

