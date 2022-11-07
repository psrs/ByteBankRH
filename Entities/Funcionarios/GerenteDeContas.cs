using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Funcionarios
{
    public class GerenteDeContas : Autenticavel
    {        
        public string Senha { get; private set; }
        public string Usuario { get; private set; }
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

        public override bool Autenticar(string usuario, string senha)
        {
            return Senha == senha && usuario == Usuario;
        }
    }
}