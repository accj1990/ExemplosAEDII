namespace atributos_metodos
{
    class AtributosMetodos
    {
        static int iterator = 0; // atributo
        static int [] vet = { 1, 2, 3, 4, 5, 6 }; // atributo
        
        public static void IteratorVector() // metodo
        {
            Console.WriteLine("Mostrando atributos e métodos C#");
            Console.WriteLine("");

            for (int i = 0; i < vet.Length; i++)
            {
                PrintElement(vet[i]);
                iterator++;
            }
        }

        private static void PrintElement (int element) // metodo
        {
            Console.WriteLine(element);
        }
    }
}
