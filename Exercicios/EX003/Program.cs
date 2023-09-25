Console.WriteLine("Informe o número do mês desejado");
int MES = int.Parse(Console.ReadLine());

switch (MES){
    case 1:
    Console.WriteLine("janeiro, tem 31 dias");
    break;

    case 2:
    Console.WriteLine("Fevereiro, tem 28 dias (29 dias nos anos bissextos)");
    break;

    case 3:
    Console.WriteLine("Março, tem 31 dias");
    break;

    case 4:
    Console.WriteLine("Abril, tem 30 dias");
    break;

    case 5:
    Console.WriteLine("Maio, tem 31 dias");
    break;

    case 6:
    Console.WriteLine("Junho, tem 30 dias");
    break;
    
    case 7:
    Console.WriteLine("Julho, tem 31 dias");
    break;

    case 8:
    Console.WriteLine("Agosto, tem 31 dias");
    break;

    case 9:
    Console.WriteLine("Setembro, tem 30 dias");
    break;

    case 10:
    Console.WriteLine("Outubro, tem 31 dias");
    break;

    case 11:
    Console.WriteLine("Novembro, tem 30 dias");
    break;

    case 12:
    Console.WriteLine("Dezembro, tem 31 dias");
    break;

    default:
    Console.WriteLine("Número inválido");
    break;
}