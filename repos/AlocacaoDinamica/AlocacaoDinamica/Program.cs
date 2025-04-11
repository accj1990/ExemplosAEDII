using AlocacaoDinamica;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world!!");

        Fila f = new Fila();

        f.Inserir(1);
        f.Mostrar();

        f.Remover();
        f.Mostrar();

        f.Remover();
        f.Inserir(2);
        f.Inserir(3);

        f.Mostrar();
        f.Remover();
        f.Mostrar();








    }
}