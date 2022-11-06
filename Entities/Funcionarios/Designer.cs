namespace ByteBankRH.Entities.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double CalculaBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}