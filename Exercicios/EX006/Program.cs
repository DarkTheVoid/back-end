using ContaBancaria;
class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("—''—''—''—''—''—''—''—''—''—''—''");
        Console.WriteLine("Bem vindo à sua Conta Bancária!");
        Console.WriteLine("—''—''—''—''—''—''—''—''—''—''—''");
        Console.WriteLine("Digite o nome do titular para acessar a conta :>");
        string titular = Console.ReadLine();
        var conta1 = new ContaCorrente(titular);

        int opcao = 8;

        do
        {
            Console.Clear();
            Console.WriteLine("——#——#——#——#Menu#——#——#——#——#");
            Console.WriteLine("1 — Para consultar saldo disponível");
            Console.WriteLine("2 — Para depositar dinheiro");
            Console.WriteLine("3 — Para sacar dinheiro");

            Console.WriteLine("Digite uma das opções acima >");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;

                case 1:
                    conta1.MostrarSaldo();
                    break;

                case 2:
                    conta1.DepositarDinheiro();
                    break;

                case 3:
                    conta1.SacarDinheiro();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != 0);
    }
}





