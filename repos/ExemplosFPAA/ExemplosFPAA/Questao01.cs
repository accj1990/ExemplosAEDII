namespace ExemplosFPAA
{
    class Questao01
    {
        public int[] A = new int[] { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };
        public Questao01() { }

        public int PesquisaBinaria(int x)
        {
            int esquerda = 0;
            int direita = A.Length - 1;

            while (esquerda <= direita)
            {
                int meio = (esquerda + direita) / 2;

                if (A[meio] == x)
                    return meio; // encontrou o elemento
                else if (A[meio] < x)
                    esquerda = meio + 1;
                else
                    direita = meio - 1;
            }

            return -1; // não encontrou o elemento
        }
    }
}
