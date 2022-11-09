using ByteBankRH.Entities.Funcionarios;

namespace ByteBankRH.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }

        public bool Autenticar(string usuario, string senha);
    }
}