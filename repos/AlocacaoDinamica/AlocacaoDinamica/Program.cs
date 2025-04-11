using AlocacaoDinamica;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world!!");

        /*Fila f = new Fila();

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
        */

        /* Pilha p = new Pilha();
         p.Inserir(1);
         p.Mostrar();
         p.Remover();
         p.Mostrar();

         p.Inserir(1);
         p.Inserir(2);
         p.Inserir(3);
         p.Inserir(4);
         p.Inserir(5);

         p.Mostrar();

         p.Remover();
         p.Remover();
         p.Mostrar();
        */

        Lista lista = new Lista();

        lista.InserirInicio(1);
        lista.InserirInicio(2);
        lista.Mostrar();

        lista.InserirFim(5);
        lista.Mostrar();
        lista.InserirFim(6);
        lista.InserirInicio(0);
        lista.Mostrar();

    }
}