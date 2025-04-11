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
        }

        public void InserirInicio(int valor)
        {
            if (primeiro == ultimo)
            {
                primeiro = new Celula(valor);
                ultimo = primeiro.prox;
            }
            else
            {
                Celula tmp = new Celula(valor);
                tmp.prox = primeiro;
                primeiro = tmp;
            }
        }

        public void InserirFim(int valor)
        {
            if (ultimo == null)
            {
                ultimo = new Celula(valor);
                primeiro.prox.prox = ultimo;
            }
            else
            {
                Celula tmp = new Celula(valor);
                ultimo.prox = tmp;
                ultimo = tmp;
            }

        }
        public void InserirPosicao(int valor, int pos)
        {


        }

        public void RemoverInicio()
        {

        }
        public void RemoverFim()
        {

        }

        public void RemoverPosicao()
        {

        }

        public void Mostrar()
        {
            Console.WriteLine(" ");
            for (Celula i = primeiro; i != null; i = i.prox)
            {
                Console.Write(i.valor + " ");
            }
        }
        // Mostrar
    }
}
