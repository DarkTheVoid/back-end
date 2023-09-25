namespace Models
{
    public class Pessoa
    {
        //atributos da nossa classe pessoa
        private string nome { get; set; }
        private int idade { get; set; }
        private string email { get; set; }
        private int anoNascimento { get; set; } 

        public Pessoa(string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }
        //Método da Classe Pessoa

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");

        }
        public void Apresentacao()
        {
            Console.WriteLine($"Olá! Meu nome é {nome}, eu tenho {idade} anos e nasci em {anoNascimento}. Meu email é {email}");
        }

        
    }
}