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

        // Inserir na fila
        public void Inserir(int valor)
        {
            if (primeiro == ultimo)
            {
                this.primeiro.valor = valor;
                this.ultimo = new Celula(-1);
                this.primeiro.prox = this.ultimo;
            }
            else
            {
                this.ultimo.valor = valor;
                this.ultimo.prox = new Celula(-1);
                this.ultimo = this.ultimo.prox;
            }
        }

        // Remover na fila

        // Mostrar fila
    }
}
