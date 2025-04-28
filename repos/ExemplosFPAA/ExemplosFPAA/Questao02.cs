namespace ExemplosFPAA
{
    public class UnificadorDeListaEstatica
    {
        private int[] A;
        private int cont;

        public UnificadorDeListaEstatica(int[] elementos)
        {
            A = new int[elementos.Length];
            Array.Copy(elementos, A, elementos.Length);
            cont = elementos.Length;
            //Ordenar(); // Garante que o vetor esteja ordenado no começo
        }

        private void Ordenar()
        {
            // Implementação simples de insertion sort para ordenar o vetor
            for (int i = 1; i < cont; i++)
            {
                int key = A[i];
                int j = i - 1;

                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key;
            }
        }

        // O(n²) com ordenar, sem é O(n)
        public int Unificar()
        {
            while (cont > 1)
            {
                // Soma os dois menores elementos
                int soma = A[0] + A[1];

                // Remove os dois primeiros elementos
                for (int i = 2; i < cont; i++)
                {
                    A[i - 2] = A[i];
                }
                cont -= 2;

                // Inserir a soma de forma ordenada
                InserirOrdenado(soma);

                // Mostrar a lista atual
                Imprimir();
            }

            // Retorna o único elemento restante
            return A[0];
        }

        private void InserirOrdenado(int valor)
        {
            int i = cont - 1;

            // Desloca os elementos para abrir espaço
            while (i >= 0 && A[i] > valor)
            {
                A[i + 1] = A[i];
                i--;
            }

            A[i + 1] = valor;
            cont++;
        }

        public void Imprimir()
        {
            for (int i = 0; i < cont; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
