namespace AlocacaoDinamica.classes
{
    public class CelulaDuplamente
    {
        public CelulaDuplamente? ant;
        public CelulaDuplamente? prox;
        public int valor;
        public CelulaDuplamente()
        {
            this.ant = this.prox = null;
        }
    }
}
