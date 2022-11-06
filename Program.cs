using System.Globalization;
using ByteBankRH.Entities.Funcionarios;
using ByteBankRH.Util;

var func = new GerenteDeContas("Paulo", "1234", 1250.0);
var diretor = new Diretor("Clotilde", "9876", 12000.0);

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
// Console.WriteLine($"Bonificação do (a) {func.Nome}: R$ {(func.CalculaBonificacao() + func.Salario).ToString("F2", CultureInfo.InvariantCulture)}");

Console.WriteLine();

Console.WriteLine($"Novo salário do (a) {diretor.Nome}: R$ {diretor.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
// Console.WriteLine($"Salário do (a) {diretor.Nome} com bonificação: R$ {(diretor.CalculaBonificacao() + diretor.Salario).ToString("F2", CultureInfo.InvariantCulture)}");