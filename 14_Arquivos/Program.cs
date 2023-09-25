using System.IO;

public class Program
{
    public static string CaminhoArquivo = "Arquivo/arquivo.txt";
    public static void Main()
    {

        GravarArquivo();
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {


            //Verificar se arquivo existe 
            if (File.Exists(CaminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando a verificação no if é falsa ou seja o arquivo não existe
                File.Create(CaminhoArquivo);
            }

            //Instianciando um objeto da Classe StreamReader para ler o arquivo
            using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");

        }

    }
    public static void GravarArquivo()
    {
        try
        {
            using (StreamWriter arquivo = new StreamWriter("Arquivo/arquivo.txt", false))
            {
                Console.WriteLine("Digite algo");

                arquivo.WriteLine(Console.ReadLine());

            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}