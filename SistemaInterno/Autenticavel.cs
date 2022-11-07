using ByteBankRH.Entities.Funcionarios;

namespace ByteBankRH.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public abstract bool Autenticar(string usuario, string senha);
    }
}