namespace AEDII.Aulas.Revisao.Parte2.Alimento
{
    public class AlimentoEstoque
    {
        private int Id;
        private string Nome { get; set; }
        private string Medida { get; set; }

        public AlimentoEstoque(int Id, string Nome, string Medida)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Medida = Medida;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string GetMedida()
        {
            return this.Medida;
        }

        public void SetMedida(string Medida)
        {
            this.Medida = Medida;
        }
    }
}
