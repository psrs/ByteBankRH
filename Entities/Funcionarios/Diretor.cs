using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Funcionarios
{
    public class Diretor : Autenticavel
    {        
        public string Senha { get; private set; }
        public string Usuario { get; private set; }
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

        public override bool Autenticar(string usuario, string senha)
        {
            return Senha == senha && Usuario == usuario;
        }
    }
}