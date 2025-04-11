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
            Celula tmp = new Celula(valor);
            tmp.prox = primeiro;
            primeiro = tmp;
        }

        public void InserirFim(int valor)
        {
            Celula tmp = new Celula(valor);
            ultimo.prox = tmp;
            ultimo = tmp;
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
            for (Celula i = primeiro; i != ultimo && i != null; i = i.prox)
            {
                Console.WriteLine(i.valor);
            }
        }
        // Mostrar
    }
}
