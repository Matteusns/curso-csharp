using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Funcionario pedro = new Funcionario("123456798", 2000);

pedro.Nome = "Pedro Sobrenome";

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321", 5000);
roberta.Nome = "Roberta Santos";

roberta.AumentarSalario();
pedro.AumentarSalario();

Console.WriteLine("Salario Roberta: " + roberta.Salario);
Console.WriteLine("Salario Pedro: " + pedro.Salario);

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine(gerenciador.TotalDeBonificacao);

Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalDeFuncionarios);