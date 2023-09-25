namespace ContaBancaria
{
    public class ContaCorrente
    {
        public string nome { get; set; }
        public int saldo { get; set; } = 0;
        //public int opcao { get; set; }

        public ContaCorrente(string nome)
        {
            this.nome = nome;
        }

        public  void MostrarSaldo()
        {
            Console.WriteLine($"{nome}, eu saldo disponível é R$");
        }

        public  void DepositarDinheiro()
        {
            Console.WriteLine($"Informe o valor a ser depositado");
            int ValorDepositado = int.Parse(Console.ReadLine());
            if (ValorDepositado <= 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                saldo += ValorDepositado;
                Console.WriteLine("Deposito feito com sucesso!");
            }
        }

        public  void SacarDinheiro()
        {
            Console.WriteLine("Digite o valor a ser sacado");
            int ValorSacado = int.Parse(Console.ReadLine());
            if (ValorSacado > saldo || ValorSacado == 0 || ValorSacado == null)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                saldo -= ValorSacado;
                Console.WriteLine("Valor sacado com sucesso!");

            }
        }

    }
}