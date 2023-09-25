//Superclasse
class Animal
{
    public  string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emiting som");
    }
}
//Classe filha
//Receberá atributos da Superclasse
class Cachorro : Animal
{
    public void Latir(){
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando");
    }
}
class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal { };
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();
        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}

