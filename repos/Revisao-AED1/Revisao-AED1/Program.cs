using complexidade;

class Program
{
    public static void Main (string[] args)
    {
        /*
         * 
         * Imprima o valor da complexidade para cada um dos exemplos e compare
         * Lembre-se que a operação relevante é a comparação entre elementos do vetor
         * 
         */
        int[] vet = {1, 2, 3, 4, 5, 6, 7};

        // exemplo em que o custo varia pois no metodo de pesquisa começo a buscar no array na posicao 1
        //Pior caso: busco o elemento de primeira posição ou não tenho o elemento buscado no vetor
        int valor1 = Exemplo01.calculaComplexidade(vet, vet[0]);
        //Console.WriteLine(valor1); // n-1

        // exemplo em que o custo varia pois no metodo de pesquisa começo a buscar no array na posicao 1
        //Melhor caso: passo o elemento da posição
        int valor2 = Exemplo01.calculaComplexidade(vet, vet[1]);
        //Console.WriteLine(valor2); // 1

        //para todos os valores contidos no vetor, gasta-se n-1
        // No caso médio teriamos (n-1) + 1 / 2

        // E o custo de calcular a pesquisa de todos os elementos ?
        int valor3 = Exemplo02.calculaComplexidadePesquisarTodosElementos(vet);
        //Console.WriteLine(valor3);

        int[] vet2 = {1,2,3,4,5,6,7};
        int valor4 = Exemplo03.calculaComplexidadePesquisarTodosElementos(vet2);
        Console.WriteLine(valor4);

    }


}