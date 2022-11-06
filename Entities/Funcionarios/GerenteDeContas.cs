namespace ByteBankRH.Entities.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double CalculaBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}