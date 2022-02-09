namespace Desafio_GFT.src.Entities
{
    public class funcionario
    {
        public funcionario(string Nome, string Matricula, double salario, string CPF)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
            this.salario = salario;
            this.CPF = CPF;
        }
        public string Nome;
        public string Matricula;

        public double salario;
        public DateTime dataAdmissao;
        public string CPF;
    }
}