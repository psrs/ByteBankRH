using System.Globalization;
using ByteBankRH.Entities.Funcionarios;
using ByteBankRH.Entities.Parceiros;
using ByteBankRH.SistemaInterno;
using ByteBankRH.Util;

string op = string.Empty;

ControleAcesso ca = new ControleAcesso();
var func = new GerenteDeContas("Quico", "1234", 1250.0, "QQ", "xpto");
var diretor = new Diretor("Clotilde", "9876", 12000.0, "CLO", "segredo");
var parceiro = new ParceiroComercial();
parceiro.Usuario = "USER1";
parceiro.Senha = "9900";

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.RegistraBonificacao(func);
gerenciador.RegistraBonificacao(diretor);

Console.WriteLine($"Salário do (a) {func.Nome}: R$ {func.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Bonifição do (a) {func.Nome}: R$ {(func.CalculaBonificacao()).ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();

Console.WriteLine($"Salário do (a) {diretor.Nome}: R$ {diretor.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Bonifição do (a) {diretor.Nome}: R$ {(diretor.CalculaBonificacao()).ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();

Console.WriteLine($"Total de bonificaçoes: R$ {gerenciador.TotalDeBonificacoes.ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Total de funcionários do banco: {Funcionario.TotalDeFuncionarios}");

func.AumentarSalario();
diretor.AumentarSalario();

Console.WriteLine();

Console.WriteLine($"Novo salário do (a) {func.Nome}: R$ {func.Salario.ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();

Console.WriteLine($"Novo salário do (a) {diretor.Nome}: R$ {diretor.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
// Console.WriteLine($"Salário do (a) {diretor.Nome} com bonificação: R$ {(diretor.CalculaBonificacao() + diretor.Salario).ToString("F2", CultureInfo.InvariantCulture)}");

ca.Logar(func, "QQ", "xpto");
ca.Logar(diretor, "CLO", "segredos");
ca.Logar(parceiro, "USER1", "9900");