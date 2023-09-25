class PROGRAM
{
    public static void Main()
    {

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no For");
        }

        for (int sesi = 10; sesi >= 0; sesi--)
        {
            Console.WriteLine($"Variável sesi vale {sesi} ");
        }

        int num = 87;
        for (int cont = 0; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} x {cont} = {num * cont}");
        }

        //declarando um vetor 
        string[] alunos = new string[35];
        //Atribuindo valores ao nosso vetor
        alunos[1] = "Abner";
        alunos[2] = "Adalberto Kaio";
        alunos[3] = "Ana Carolina";
        alunos[34] = "Samuel";

        foreach (string aluno in alunos)
        {
            if (aluno != null)
                Console.WriteLine(aluno);
        }

        int[] cadeiras = new int[5];
        cadeiras[0] = 5;
        cadeiras[4] = 34;
        cadeiras[1] = 69;
        cadeiras[2] = 99;
        cadeiras[3] = 50;

        int laura = 0;   //soma
        int jorge = 0;  //maior
        int bianca = 100;  // menor
        foreach (int enzo in cadeiras)
        {
            laura = laura + enzo;
            if (enzo < jorge)
            {
                jorge = enzo;
            }
            if (enzo < bianca)
            {
                bianca = enzo;
            }
        }
        Console.WriteLine($"Soma: {laura}, Maior {jorge}, Menor {bianca}");

        Array.Sort(cadeiras);

        for (int X = 0; X < cadeiras.Length; X++){
            Console.WriteLine($"posição {X} - valor {cadeiras[X]}");
        }

    }



}


