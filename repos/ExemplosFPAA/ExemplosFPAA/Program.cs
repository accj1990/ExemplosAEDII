class Program
{
    public static void Main(string[] args)
    {
        int[] valores = { 1, 2, 3, 4, 5, 14, 25, 35 };

        valores = unifica(valores); // 3, 3, 4, 5, 14, 25, 35

        valores = unifica(valores); // 4, 5, 6, 14, 25, 35

        // ...

    }

    public static int[] unifica(int[] valores)
    {




        return valores;
    }

    public static int[] removerElementos(int[] valores)
    {
        int x = valores[0];
        int y = valores[1];

        int soma = x + y;

        for (int i = 2; i < valores.Length; i++)
        {

        }

        return valores;
    }
}