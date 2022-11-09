using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }

        protected FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public bool Autenticar(string usuario, string senha)
        {
            return usuario == Usuario && senha == Senha;
        }
    }
}