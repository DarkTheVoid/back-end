Console.WriteLine("Digite o número da placa");
string ValorPlaca = Console.ReadLine();

int PlacaRodizio = int.Parse(ValorPlaca.Substring(6));

switch (PlacaRodizio) {
    case 1:
    Console.WriteLine("Segunda");
    break;
     case 2:
    Console.WriteLine("Segunda");
    break;

     case 3:
    Console.WriteLine("Terça");
    break;
     case 4:
    Console.WriteLine("Terça");
    break;

     case 5:
    Console.WriteLine("Quarta");
    break;
    case 6:
    Console.WriteLine("Quarta");
    break;

    case 7:
    Console.WriteLine("Quinta");
    break;
    case 8:
    Console.WriteLine("Quinta");
    break;

    case 9:
    Console.WriteLine("Sexta");
    break;
    case 0:
    Console.WriteLine("Sexta");
    break;

    default:
    Console.WriteLine("Placa inválida");
    break;
}