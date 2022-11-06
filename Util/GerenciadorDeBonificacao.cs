using ByteBankRH.Entities.Funcionarios;

namespace ByteBankRH.Util
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }

        public void RegistraBonificacao(Funcionario func)
        {
            TotalDeBonificacoes += func.CalculaBonificacao();
        }
    }
}