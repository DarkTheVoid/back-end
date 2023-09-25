public class Program
{
    public static void Main()
    {
        //Criando uma classe anônima (classe sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br",
        };
        Console.WriteLine($"A pessoa é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa é {pessoa2.nome} e tem {pessoa2.email} anos");
        
        //pessoa1.nome = "Douglas";

        var carro1 = new{
            nome = "VW",
            modelo = "Gol",
            ano = 2020
        };
        var carro2 = new{
            nome = "Ford",
            modelo = "Ranger",
            ano = 2015
        };
        Console.WriteLine($"o nome do carro é {carro1.nome}, seu modelo é {carro1.modelo} e seu ano é {carro1.ano}");
        Console.WriteLine($"o nome do carro é {carro2.nome}, seu modelo é {carro2.modelo} e seu ano é {carro2.ano}");
    }
}