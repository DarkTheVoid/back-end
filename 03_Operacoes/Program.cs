Console.WriteLine("Digite o valor de X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de Y:");
int y = int.Parse(Console.ReadLine());

//Exemplos de operadores aritméticos
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; //Calculando o resto da divisão de x / 2
int restoDivY2 = y % 2;

//Console para exibir na tela as variáveis em cada linha
//Soma: 15

Console.WriteLine($"{x} + {y} = {soma}");
Console.WriteLine($"{x} - {y} = {subtracao}");
Console.WriteLine($"{x} * {y} = {multiplicacao}");
Console.WriteLine($"{x} / {y} = {divisao}");
Console.WriteLine($"{x} % {y} = {resto}");


//Revisão de If
if (restoDiv2 == 0)
{
    Console.WriteLine($"O número {x} é par");
}
else
{
    Console.WriteLine($"O número {x} é impar");
}

if (restoDivY2 == 0)
{
    Console.WriteLine($"O número {y} é par");
}
else
{
    Console.WriteLine($"O número {y} é impar");
}

string resultado = (restoDivY2 == 0) ? $"O número {y} é par" : $"O número {y} é impar";
Console.WriteLine(resultado);


//Int ---> Var/Let
//A formula acima funciona como um If/Else
//String "resultado" = ---> nesse caso é para criar uma 'var', um compartimento para guardar a informação do nosso If
//(Int)

int DiaSemana = 3;
//Aprendendo o Switch Case
switch (DiaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo!");
        break;

    case 2:
        Console.WriteLine("Hoje é Segunda!");
        break;

    case 3:
        Console.WriteLine("Hoje é Terça!");
        break;

    case 4:
        Console.WriteLine("Hoje é Quarta!");
        break;

    case 5:
        Console.WriteLine("Hoje é Quinta!");
        break;

    case 6:
        Console.WriteLine("Hoje é Sexta!");
        break;

    case 7:
        Console.WriteLine("Hoje é Sábado!");
        break;

        default:
        Console.WriteLine("Dia inválido");
        break;
}