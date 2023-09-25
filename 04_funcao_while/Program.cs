//Function → Método | mesma coisa
//function nomeFuncao(nome){}
//public static void nomeFuncao(string nome){}

class Sesi
{

    public static void Main() //ponto de entrada
    {
        //Chamando métodos sem retorno 
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem("SESI / SENAI");
        ImprimeDataHora();
        //Chamando o método Potenciação com o parâmetro 4 e recebendo o retorno
        double potencia = Potenciasao(4);
        Console.WriteLine($"Potenciação {potencia}");

        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }

    //Método com parâmetro e com retorno
    public static double Potenciasao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }


    //Método sem parâmetro e sem retorno → ()vazias
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

    //Método com parâmetro e sem retorno → () com conteúdo
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while(n >= 0){
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(5);
        }
        Console.WriteLine("BOOOOOOOOOOOOM!!");
    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("              Bem vindo ao Jogo              ");
        Console.WriteLine(" Sorteei um nº de 1 a 20. tente adivinhá-lo  ");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("");

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
            Console.WriteLine("O número digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabéns você acertou");
    }

}


//Void → caso a função não retorne nada
//Int → caso retorne um número
//String → caso retorne uma string (??)  