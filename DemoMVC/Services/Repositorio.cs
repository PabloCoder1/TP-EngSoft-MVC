using DemoMVC.Models;

namespace DemoMVC.Services
{
    public class Repositorio
    {
        public List<Aluno> alunos = new List<Aluno>();

        public Repositorio()
        {
            alunos.Add(new Aluno{ Carro = "Lancer", Ano = "2015", Modelo = "EVO"});
            alunos.Add(new Aluno { Carro = "Civic", Ano = "2015", Modelo = "TypeR" });
            alunos.Add(new Aluno { Carro = "Uno", Ano = "1998", Modelo = "Turbo" });
            
        }

        public List<Aluno> GetAlunos()
        {
            return alunos;
        }



        public Aluno? GetAlunoByCarro(string Carro)
        {
            Aluno? aluno = alunos.FirstOrDefault(a => a.Carro == Carro);
            return aluno;
        }

    }

}
