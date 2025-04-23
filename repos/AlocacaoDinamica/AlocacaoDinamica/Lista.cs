using AlocacaoDinamica.classes;

namespace AlocacaoDinamica
{
    public class Lista
    {
        public Celula? primeiro;
        public Celula? ultimo;

        public Lista()
        {
            this.primeiro = this.ultimo = null;
            //this.primeiro = this.ultimo = new Celula(-1);
        }

        public void InserirInicio(int valor)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = new Celula(valor);
                ultimo = ultimo.prox;
            }
            else if (ultimo == null)
            {
                Celula tmp = new Celula(valor);
                tmp.prox = primeiro;
                primeiro = tmp;
                ultimo = primeiro.prox;
                tmp = null;
            }
            else
            {
                Celula tmp = new Celula(valor);
                tmp.prox = primeiro;
                primeiro = tmp;
                tmp = null;
            }
        }

        public void InserirFim(int valor)
        {
            if (primeiro == ultimo)
            {
                primeiro = ultimo = new Celula(valor);
                ultimo = ultimo.prox;
            }
            else
            {
                ultimo!.prox = new Celula(valor);
                ultimo = ultimo.prox;
            }
        }
        public void InserirPosicao(int valor, int pos)
        {
            int cont = 0;
            Celula i;
            for (i = primeiro!; i != null && i.prox != null && cont < pos - 1; i = i!.prox!, cont++) ;

            Celula tmp = new Celula(valor);

            if (i == primeiro)
            {
                tmp.prox = primeiro;
                primeiro = tmp;
            }
            else
            {
                tmp.prox = i.prox;
                i.prox = tmp;
            }
        }

        public int? RemoverInicio()
        {
            Celula tmp = primeiro!;
            int valor = (int)tmp.valor!;
            primeiro = tmp.prox;

            tmp.prox = null;
            tmp = null;
            return valor;
        }
        public int RemoverFim()
        {
            int cont = -1;
            if (ultimo == null)
            {
                Console.WriteLine("Lista vazia não posso remover.");
            }
            else
            {
                cont = (int)ultimo!.valor!;
                Celula i;
                for (i = primeiro!; i != null && i.prox != ultimo; i = i.prox!) ;

                ultimo = i;
                i.prox = null;
            }

            return cont;
        }

        public void RemoverPosicao(int pos)
        {
            int cont = 0;
            Celula i;
            for (i = primeiro!; i.prox != null && cont < pos - 1; i = i!.prox!, cont++) ;

            Celula tmp = i;

            tmp.prox = tmp.prox!.prox;
            tmp = null;
        }

        public void Mostrar()
        {
            Console.WriteLine(" ");
            for (Celula i = primeiro!; i != null; i = i.prox!)
            {
                Console.Write(i.valor + " ");
            }
            Console.WriteLine(" ");
        }
        // Mostrar
    }
}
