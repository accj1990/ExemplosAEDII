using AlocacaoDinamica.classes;

namespace AlocacaoDinamica
{
    public class Fila
    {
        public Celula primeiro;
        public Celula ultimo;
        public Fila()
        {
            this.primeiro = ultimo = new Celula(-1);
        }

        public void Inserir(int valor)
        {
            if (primeiro == ultimo)
            {
                this.primeiro.valor = valor;
                this.ultimo = new Celula(null);
                this.primeiro.prox = this.ultimo;
            }
            else
            {
                this.ultimo.valor = valor;
                this.ultimo.prox = new Celula(-1);
                this.ultimo = this.ultimo.prox;
            }
        }

        public int? Remover()
        {
            if (primeiro == ultimo && primeiro.valor == null)
            {
                Console.WriteLine("Fila vazia, não é possível remover.");
                return -1;
            }
            else
            {
                int? valor = primeiro.valor;
                Celula tmp = primeiro;
                primeiro = primeiro.prox;
                tmp.prox = null;
                return valor;
            }
        }

        public void Mostrar()
        {
            if (primeiro == ultimo && primeiro.valor == null)
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                for (Celula i = primeiro; i.prox != null; i = i.prox)
                {
                    Console.WriteLine(i.valor);
                }
            }
        }
    }
}
