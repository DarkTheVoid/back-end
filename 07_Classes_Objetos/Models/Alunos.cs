// O namespace é um nome em que usaremos para fazer referências quando usarmos 
//em outras classe
namespace Sesi.Model{

    //Declarando nossa classe Aluno
    public class Aluno{
        //Declarando nossos atributos (propriedade) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        private int nrFaltas { get; set; }

        //Criando um método

        public void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos e sou da turma {turma}");
        }

        public void AdicionarFaltas(int nr){
            nrFaltas = nrFaltas + nr;
        }


        public void ResumirFaltas(){
            Console.WriteLine($"{nome} você tem {nrFaltas} faltas");
        }

        public void JustificarFaltas(int nr){
            nrFaltas = nrFaltas - nr;
        }
    }
}
