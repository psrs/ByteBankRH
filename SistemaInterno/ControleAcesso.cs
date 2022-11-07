using ByteBankRH.Entities.Funcionarios;

namespace ByteBankRH.SistemaInterno
{
    public class ControleAcesso
    {
        public bool Logar(Autenticavel autenticavel, string usuario, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(usuario, senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"{autenticavel.Nome}, bem vindo ao Sistema ByteBankRH");
                return true;
            }
            
            Console.WriteLine("Senha inválida e/ ou senha inválidos.");
            return false;
        }
    }
}