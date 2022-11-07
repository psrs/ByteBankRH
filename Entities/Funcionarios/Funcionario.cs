namespace ByteBankRH.Entities.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; protected set; }
        public string Cpf { get; protected set; }
        public double Salario { get; protected set; }        

        public static int TotalDeFuncionarios { get; private set; } = 0;

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract double CalculaBonificacao();

        public abstract void AumentarSalario();
    }
}