using System;

namespace Executavel
{
    public class Carro
    {
        public string Modelo;
        public int Ano;

        public Carro(string Modelo, int Ano)
        {
            this.Modelo = Modelo;
            this.Ano = Ano;
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando o carro...");
        }
    }
}
