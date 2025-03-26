using System;
using AEDII.Aulas.Revisao.Parte2.Alimento;
using AEDII.Aulas.Revisao.Parte2.Interfaces;

namespace AEDII.Aulas.Revisao.Parte2.Estoque
{
    public class EstoqueEstatico : IEstoque
    {
        public AlimentoEstoque[] estoque;
        private int cont = 0;

        public EstoqueEstatico(int tam)
        {
            this.estoque = new AlimentoEstoque[tam];

        }

        public bool Inserir(AlimentoEstoque e)
        {
            if (cont < estoque.Length)
            {
                estoque[cont] = e;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Estoque cheio!!");
                return false;
            }

        }

        public bool Excluir(int Id)
        {
            if (cont < 0)
            {
                Console.WriteLine("Estoque vazio, por isso não é possível excluir.");
                return false;
            }

            bool resp = false;
            for (int i = 0; i < estoque.Length; i++)
            {
                AlimentoEstoque e = estoque[i];
                if (e != null)
                    if (e.GetId() == Id)
                    {
                        estoque[i] = null;
                        resp = true;
                        i = estoque.Length;
                    }
            }
            return resp;
        }

        public void Exibir()
        {
            for (int i = 0; i < estoque.Length; i++)
            {
                AlimentoEstoque e = estoque[i];
                Console.WriteLine($"" +
                    $"Id: {e.GetId()} " +
                    $"Nome Produto: {e.GetNome()} " +
                    $"Medida: {e.GetMedida()}");
            }

            Console.WriteLine($" Total do Estoque: {estoque.Length}");
        }

        public void Ordenar(string criterio)
        {
            throw new System.NotImplementedException();
        }
    }
}
