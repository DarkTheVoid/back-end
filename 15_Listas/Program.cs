using System.Collections.Generic;
using Sesi.Model;

public class Program
{
    public static void Main()
    {
        /*
         //todo Criar uma lista de inteiros  List<T> (T = o tipo)
         List<int> numeros = new List<int>();
         List<string> Palavras = new List<string>();
         //todo new → uma nova instancia
         //todo Parentêses vazios → Não vamos começar a lista com nenhum elemento
         //todo Adicionar elementos à lista
         numeros.Add(10);
         numeros.Add(20);
         numeros.Add(30);

         //todo Tentativa de lista baseado na anterior
         Palavras.Add("Cachorro");
         Palavras.Add("Gato");
         Palavras.Add("Pássaro");
         Palavras.Add("Sapo");

         //todo Acessar elementos por índice
         Console.WriteLine(numeros[0]); //*Saída: 10
         Console.WriteLine(Palavras[2]); //*Saída: 10

         //todo Contagem de elementos na lista
         Console.WriteLine($"Contagem de elementos:{numeros.Count}"); //*Saída
         Console.WriteLine("Quantidade de animais: " + Palavras.Count); //*Saída
                                                                        //*As duas formas darão a quantidade de elementos 

         numeros.Add(45);
         Console.WriteLine($"Contagem de elementos:{numeros.Count}"); //*Saída
         //todo Dá pra adicionar um elemento a qualquer momento na lista

         List<int> teste = new List<int>();
         teste.Add(1);
         teste.Add(2);
         teste.Add(3);
         teste.Add(4);
         Console.WriteLine($"Seu número é: {teste.Count}");
         


        List<string> Nomes = new List<string>();
        Console.WriteLine("Me fale três nomes para a lista");
        Nomes.Add(Console.ReadLine());
        Nomes.Add(Console.ReadLine());
        Nomes.Add(Console.ReadLine());

        Console.WriteLine($"Sua lista contém: {Nomes.Count} nomes");
        foreach (string item in Nomes)
        {
            Console.WriteLine(item);
        }


        //!  List<int> Numeroro = new List<int> { 1, 34, 373, 3, 99, 6 };
        //! Console.WriteLine($"Sua lista tem: {Numeroro.Count}"); 

         List<string> OOO = new List<string> { "Paulo", "Roberta", "Pablo" };
         Console.WriteLine($"Sua lista tem: {OOO.Count}");
         Console.WriteLine("Alguém morreu :'(");
         OOO.RemoveAt(1);
         Console.WriteLine($"Sua lista tem: {OOO.Count}");
         Console.WriteLine("A família foi atacada!");
         OOO.RemoveRange(0, 2);
         Console.WriteLine($"Sua lista tem: {OOO.Count}");
         //RemoveAt → Remover o ÍNDICE
         //Remove → Remover o elemento em si
         //RemoveRange → Remover um elemento a partir do índice (EX. EXcluir a partir do índice 0, 2 elementos)


        
        //Substituindo informação do item da lista
        List<int> NumeroTeste = new List<int> { 1, 4, 3 };
        NumeroTeste[1] = 2;

        //Iterando sobre todos os itens da lista
        foreach (int numero in NumeroTeste)
        {
            Console.WriteLine(numero);
        }*/



        //?Criando uma lista com objetos
        //todo Criando uma lista com objetos da Classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();


        //todo Adicionando um novo aluno à minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);


        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));


        //todo Exibindo lista de alunos
        Console.WriteLine("Lista de Alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade}");
        }

        //todo Criando uma nova lista, ordenada por nome
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        var consulta = listaAlunos
                            .Where(aluno => aluno.idade == 17)
                            .OrderBy(aluno => aluno.nome);
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
    }
}

