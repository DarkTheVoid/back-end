public class Program
{
    public static void Main()
    {
        //o TRY serve para tratar um erro e não parar a execução do programa
        //Se ocorrer qualquer erro dentro do bloco try, o sistema interrompe a execução do bloco e vai para o CATCH
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº{numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"Aqui está o resultado! {resultado}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Este número inteiro é maior que o suportado");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite um número inteiro");
        }
        //CATCH é o tratamento do erro, normalmente colocamos as mensagens de acordo com o tipo do erro, para melhor compreensão do usuaário
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        //O FINALLY é um bloco executado independentemente se ocorrer um erro ou não 
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}
