//Somente declarando uma variável do tipo inteira e sem valor
//int num1; 

//Declarando uma variável com valor
//int num2 = 5;

//Declarando uma variável com um nome/String
//string NomeAluno = 'Darkness';

//Variável do tipo lógico (true ou false)
//bool resultado = true;

//variável do tipo double valor com várias casas decimais 
//double coordenada = 1.854352678;

///Variável do tipo decimal - utilizada para valores 
//decimal valor = 1.80m;


int idade = 17;
string meuNome = "Darkness";

Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");

//Para poder acionar o Console = dotnet run

//ReadLine serve apenas para que eu receba uma informação do usuário 
//e armazeno em uma variável
Console.WriteLine("Em qual cidade você nasceu?");
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");