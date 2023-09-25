class Program
{
    public static void Main()
    {
        ListaDoChurrasco();
        ListaSonho();
    }

    public static void ListaDoChurrasco()
    {
        string[] lista = new string[6];

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Digite o nome das carnes desejadas");
            string produto = Console.ReadLine();

            lista[i] = produto;
        }
        Console.WriteLine("Aqui está sua lista em ordem");
        Array.Sort(lista);
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }

    public static void ListaSonho(){
        string[] sonhos = new string[3];
        decimal[] valores = new decimal[3];
        decimal total = 0;


        for (int i = 0; i < 3; i++){
            Console.WriteLine($"Informe o seu {i} sonho");
            string sonho = Console.ReadLine();
            Console.WriteLine($"Informe o valor do {i}º sonho");
            decimal valor = decimal.Parse(Console.ReadLine());
            sonhos[i] = sonho;
            valores[i] = valor;
        }

        foreach (decimal val in valores){
            total = total + val;
        }
        Console.WriteLine($"Seus sonhos custarão aprox. R${total}");
    }


}