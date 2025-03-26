using atributos_metodos;
using condicionais;
using modificadores_acesso;
using repeticoes;
using tipo_dados;

namespace revisao_1
{
    // parte 1
    class Program
    {
        public static void Main(string[] args)
        {
            // Tipos de dados e variáveis
            TipoDados.MostrarTiposDados();
            Console.WriteLine("");

            // Atributos e Métodos
            AtributosMetodos.IteratorVector();

            // Modificadores de acesso
            ModificadoresAcessoExemplo01 exemplo01 = new ModificadoresAcessoExemplo01();
            Console.WriteLine(exemplo01.Id);
            Console.WriteLine(exemplo01.getNome());
            exemplo01.setNome("Ana Carolina");
            Console.WriteLine(exemplo01.getNome());
            exemplo01.PrintIdExemplo02(5);
            exemplo01.PrintIdExemplo01();
            Console.WriteLine("Alterando o Id fora da classe");
            exemplo01.Id = 8;
            Console.WriteLine("O novo valor será..");
            exemplo01.PrintIdExemplo01();
            exemplo01.PrintIdExemplo02(6);
            Console.WriteLine("Atributo Id vale acessado de dentro");
            exemplo01.PrintIdExemplo01();
            Console.WriteLine("Atributo Id acessado de fora " +  exemplo01.Id);

            // Condicionais
            BrincandoComCondicionais.ExemploCondicional01();
            BrincandoComCondicionais.ExemploCondicional02();
            BrincandoComCondicionais.ExemploCondicional03(1,2);
            BrincandoComCondicionais.ExemploCondicional03(2, 1);
            BrincandoComCondicionais.ExemploCondicional03(1, 1);

            //Bincando com repetições
            Repeticoes.RepeticaoComForExemplo01();
            Repeticoes.RepeticaoComForExemplo02();

            
            ModificadoresAcessoExemplo01.ImprimirValores();

        }
    }
}