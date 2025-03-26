using System;

namespace AEDII.Aulas
{
    public class A
    {
        protected int x = 10;

        public void ExibirValor()
        {
            Console.WriteLine($" Classe A - Valor x = {x}");
        }
    }
    public class B : A
    {
        public static void Main()
        {
            A a = new A();
            B b = new B();
            Console.WriteLine($" Valor x = {b.x}");
            //Console.WriteLine($" Valor x = {a.x}"); // não é possível acessar o valor de A, de fora da classe.
            a.ExibirValor();

        }
    }
}
