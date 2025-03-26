using AEDII.Aulas.Revisao.Parte2.Alimento;

namespace AEDII.Aulas.Revisao.Parte2.Interfaces
{
    interface IEstoque
    {
        public bool Inserir(AlimentoEstoque e);

        public bool Excluir(int Id);

        public void Ordenar(string criterio);

        public void Exibir();
    }
}
