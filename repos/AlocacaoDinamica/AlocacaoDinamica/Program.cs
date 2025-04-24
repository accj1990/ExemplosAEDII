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
        lista.InserirPosicao(7, 0);
        lista.RemoverPosicao(0);

        lista.InserirInicio(1);
        lista.InserirInicio(2);
        lista.Mostrar();

        lista.InserirFim(5);
        lista.InserirFim(6);
        lista.Mostrar();

        lista.InserirInicio(0);
        lista.Mostrar();

        lista.InserirPosicao(7, 0);
        lista.Mostrar();
        lista.InserirPosicao(8, 3);
        lista.InserirPosicao(9, 4);
        lista.Mostrar();

        lista.InserirFim(10);
        lista.InserirFim(5);
        lista.Mostrar();

        lista.RemoverPosicao(3);
        lista.RemoverPosicao(4);
        lista.Mostrar();

        lista.RemoverInicio();
        lista.RemoverInicio();
        lista.Mostrar();

        lista.RemoverFim();
        lista.RemoverFim();

        lista.Mostrar();
        lista.RemoverPosicao(6);
        lista.Mostrar();




    }
}