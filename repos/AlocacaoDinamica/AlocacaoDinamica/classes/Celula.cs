namespace AlocacaoDinamica.classes
{
    public class Celula
    {
        public int valor;
        public Celula? prox;
        public Celula(int valor)
        {
            this.valor = valor;
            this.prox = null;
        }
    }
}
