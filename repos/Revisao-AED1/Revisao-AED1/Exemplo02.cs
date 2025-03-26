namespace complexidade
{
    class Exemplo02
    {
        public static int calculaComplexidadePesquisarTodosElementos(int[] vet)
        {
            int cont = 0;

            for (int j = 0; j < vet.Length; j++)
            { 
                
                cont+= pesquisar(vet, vet[j]);


            }
            return cont;
        }

        public static int pesquisar(int[] vet, int x)
        {
            int contador = 0;
            for (int i = 1; i < vet.Length; i++)
            {
                contador++;
                if (vet[i] == x) // operação relevante
                {
                    return contador;
                }
            }

            return contador;
        }
    }
}
