using ByteBankRH.Entities.Funcionarios;

namespace ByteBankRH.SistemaInterno
{
    public class ControleAcesso
    {
        public bool Logar(IAutenticavel autenticavel, string usuario, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(usuario, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Autenticado no Sistema ByteBankRH");
                return true;
            }
            
            Console.WriteLine("Senha inválida e/ ou senha inválidos.");
            return false;
        }
    }
}