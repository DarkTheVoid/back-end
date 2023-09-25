class Program
{
    public static string[] poltronas = new string[43];

    public static void Main()
    {

        Console.Clear();
        Console.WriteLine("Bem-Vindo ao SESIbus");
        Console.WriteLine("---------------------");
        Console.WriteLine("Contamos com 42 lugares disponíveis");

        Menu();
    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine("############ MENU ############");
            Console.WriteLine("1 - Para comprar passagens");
            Console.WriteLine("2 - Para poltronas disponíveis");
            Console.WriteLine("0 - Para fechar o sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000);
                    break;

                case "1":
                    ComprarPassagem();
                    break;

                case "2":
                    PoltronasDisponíveis();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        } while (opcao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quatas passagens você deseja?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona {i}ª passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o nome do passageiro?");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponíveis(){
        Console.WriteLine("Lista de poltronas disponíveis");
        for (int i = 1; i <= 42; i++){
            if (poltronas[i] == null){
                Console.WriteLine($"Nº{i}");
            }
        }
    }

}