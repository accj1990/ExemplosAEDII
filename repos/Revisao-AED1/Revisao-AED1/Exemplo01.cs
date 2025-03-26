namespace complexidade
{
    class Exemplo01
    {
        public static int calculaComplexidade(int [] vet, int x)
        {
            int cont = pesquisar(vet, x);

            return cont;
        }

        public static int pesquisar(int [] vet, int x)
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
