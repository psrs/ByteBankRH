using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string nome, string cpf, double salario, string usuario, string senha) : base(nome, cpf, salario)
        {
            Usuario = usuario;
            Senha = senha;
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