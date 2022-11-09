using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {        
        public Diretor(string nome, string cpf, double salario, string usuario, string senha) : base(nome, cpf, salario)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public override double CalculaBonificacao()
        {
            return Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}