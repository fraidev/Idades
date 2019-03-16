namespace Idades.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}