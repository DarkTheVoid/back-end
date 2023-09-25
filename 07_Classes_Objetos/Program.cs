using Sesi.Model;
class Program
{
    public static void Main()
    {
        //Criando uma variável aluno1 e instanciando da classe Aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Darkness";
        aluno1.idade = 17;
        aluno1.turma = "2ªEnsino Médio";

        //Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();




        var aluno2 = new Aluno();
        aluno2.nome = "Paulo";
        aluno2.idade = 23;
        aluno2.turma = "3ªEnsino Médio";
        aluno2.Apresentar();

        var aluno3 = new Aluno();
        aluno3.nome = "Judas";
        aluno3.idade = 400;
        aluno3.turma = "1ªEnsino Médio";
        aluno3.Apresentar();

        var aluno4 = new Aluno();
        aluno4.nome = "Maria";
        aluno4.idade = 11;
        aluno4.turma = "5ªEnsino Médio";
        aluno4.Apresentar();
    }
}
