namespace ByteBankRH.Entities.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double CalculaBonificacao()
        {
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}