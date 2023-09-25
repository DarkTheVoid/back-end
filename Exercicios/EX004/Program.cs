class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número");
        int nrDigitado = int.Parse(Console.ReadLine());
        Console.WriteLine($"O Dobro de {nrDigitado} é igual á {Dobro(nrDigitado)}");
        Console.WriteLine($"A Metade de {nrDigitado} é igual á {Divisao(nrDigitado)}");

        Tabuada(nrDigitado);
        SomaWhile();
    }
    public static int Dobro(int valor)
    {
        int resultado = (valor * 2);
        return resultado;
    }

    public static int Divisao(int valor)
    {
        int resultadoD = (valor / 2);
        return resultadoD;
    }

public static void Tabuada(int valor){
    int contador = 1;

    while(contador <= 10){
        Console.WriteLine($"{valor} x {contador} = {valor * contador}");
        contador++;
    }
    
}

public static void SomaWhile(){
    int soma = 0;
    int menor = 10000;
    int maior = 0 ;
    int comp = 0;

    do{
        Console.WriteLine("Digite o valor desejado");
        comp = int.Parse(Console.ReadLine());

       if(comp > 0){}
        soma = soma + comp;

        if(comp > maior){
            maior = comp;
        }
        if(comp < menor && comp > 0){
            menor = comp;
        }

    } while(comp > 0);
    Console.WriteLine($"A soma dos números é {soma}, o maior número é {maior}, e o menor é {menor}");
}

} 