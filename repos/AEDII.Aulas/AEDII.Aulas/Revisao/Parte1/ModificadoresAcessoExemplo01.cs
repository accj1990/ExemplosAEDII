using System;
using repeticoes;

namespace modificadores_acesso
{
    class ModificadoresAcessoExemplo01 : Repeticoes
    {
        // public : consigo acessar fora da classe sem precisar de um método
        public int Id { get; set; }

        // private : // preciso de gets para pegar o valor fora da classe e de set para mudar o valor desse atributo
        private string Nome;

        // quando usa-se get e sets assim não precisa criar os métodos
        private string Message { get; set; } = string.Empty;

        public ModificadoresAcessoExemplo01()
        {
            Console.WriteLine("Modificadores de Acesso");
            Console.WriteLine("");
            Id = 1;
            Nome = "Dexter";

            PrintIdExemplo03(); // método privado não é acessível fora da classe
        }

        public void PrintIdExemplo01()
        {
            Console.WriteLine("Atributo da classe: " + this.Id);
        }

        // escopo do método
        public void PrintIdExemplo02(int Id)
        {
            Console.WriteLine("Valor recebido por parâmetro: " + Id);
        }

        private void PrintIdExemplo03()
        {
            Console.WriteLine(Id);
        }

        // Quando o atributo é privado é necessário criar
        // gets e sets para cada um deles ou declarar 
        // Sintaxe: private type atribute { get; set;}
        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public static void ImprimirValores()
        {
            Console.WriteLine($" Imprimindo atributo protected {Valores}");
            for (int i = 0; i < Valores.Length; i++)
            {

                Console.WriteLine(Valores[i]);

            }
        }
    }
}
