//Exercício 001 Calculando a média de 3 notas de um aluno

//receber o nome do aluno e armazenar em uma variável do tipo string

//Receber a nota 1, converter armazenar em uma variável int

//Receber a nota 2, converter e armazenar em uma variável int

//Receber a nota 3, converter e armazenar em uma variável int

//Declarar uma variável do tipo int, para receber a média das notas
//(Nota1 + nota2 + nota3) / 3

//Exibir uma mensagem se o aluno está aprovado considerando nota acima de 7

//!Criando um calculador de notas

Console.WriteLine("Informe seu nome");
string NomeAluno = (Console.ReadLine());

Console.WriteLine("Digite o valor de suas notas, por favor,");

Console.WriteLine("No primeiro período");
int Nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("No segundo período");
int Nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("No terceiro período");
int Nota3 = int.Parse(Console.ReadLine());


int ResultNotas = (Nota1 + Nota2 + Nota3) / 3;

string ResultadoAluno = (ResultNotas >= 7) ? $"Parabéns! O aluno {NomeAluno} foi aprovado" : $"Lamento, o aluno {NomeAluno} não foiu aprovado";
Console.WriteLine(ResultadoAluno);