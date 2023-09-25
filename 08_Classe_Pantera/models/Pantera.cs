namespace 

{

    public class Pantera
    {

        public string nome { get; set; }
        public decimal tamanho { get; set; }
        public int peso { get; set; }
        public string cor { get; set; }
        public string especie { get; set; }
        public string alimentacao { get; set; }

        public void Correr()
        {
            Console.WriteLine($"{nome} está correndo");
        }

        public void Cacar(){
            Console.WriteLine($"{nome} está caçando");
        }

        public void Reproduzir(){
            Console.WriteLine($"{nome} encontrou um parceiro para se reproduzir");
        }
    }
}