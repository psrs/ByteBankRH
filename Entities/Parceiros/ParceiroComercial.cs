using ByteBankRH.SistemaInterno;

namespace ByteBankRH.Entities.Parceiros
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public string Usuario { get; set; }

        public bool Autenticar(string usuario, string senha)
        {
            return usuario == Usuario && senha == Senha;
        }
    }
}