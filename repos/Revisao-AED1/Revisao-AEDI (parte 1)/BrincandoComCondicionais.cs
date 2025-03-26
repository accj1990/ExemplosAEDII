namespace condicionais
{
    public static class BrincandoComCondicionais
    {
        public static void ExemploCondicional01()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Exemplo Condicional 01");

            bool isLigado = false;

            if (isLigado)
            {
                System.Console.WriteLine("Ligado!!");
            }
            else
            {
                System.Console.WriteLine("Deligado!!");
            }
        }

        public static void ExemploCondicional02()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Exemplo Condicional 02");

            bool isLigado = true;

            if (isLigado)
            {
                System.Console.WriteLine("Ligado!!");
            }
            else
            {
                System.Console.WriteLine("Deligado!!");
            }
        }

        public static bool ExemploCondicional03(int a, int b)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Exemplo Condicional 03");


            Console.WriteLine($"a={a} e b={b}");

            if (a > b)
            {
                Console.WriteLine(" a é maior que b e retorno true ");
                return true;
            }
            else if (b > a)
            {
                Console.WriteLine(" a é menor que b e retorno false ");
                Console.WriteLine(" b é maior que a e retorno false ");

                return false;
            }
            else
            {
                System.Console.WriteLine("Os valores a e b são iguais!!");
                return !false;
            }
        }
    }
}
