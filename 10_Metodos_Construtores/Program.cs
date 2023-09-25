using Models;

public class Program
{
    public static void Main()
    {
        //Criando um Objeto da Classe Pessoa
        //Instanciando sem um método construtor

      /*  Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Dark";
        pessoa1.idade = 17;
        pessoa1.Cantar();
        pessoa1.Apresentacao();

        //Alternativa para criação de um Objeto sem construtor
        Pessoa pessoa2 = new Pessoa()
        {
            nome = "Ricardo",
            idade = 22
        };
        pessoa2.Cantar();
*/

    Pessoa pessoa1 = new Pessoa("Douglas", 32, "douglas.camata@docente.senai.br");
    pessoa1.Cantar();
    pessoa1.Apresentacao();

    Pessoa pessoa2 = new Pessoa("Dark", 17, "darknesItsMe@eissoai.com");
    pessoa2.Apresentacao();
    }
}