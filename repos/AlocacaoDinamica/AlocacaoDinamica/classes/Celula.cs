namespace AlocacaoDinamica.classes
{
    public class Celula
    {
        public int? valor;
        public Celula? prox;

        public Celula(int? v)
        {
            valor = v;
            this.prox = null;
        }
    }
}
