using bytebank.Contas;
using bytebank.Titular;

Cliente cliente = new Cliente();

cliente.nome = "Andrá Silva";
cliente.cpf = "123456789";
cliente.profissao = "Analista";


ContaCorrente conta = new ContaCorrente();
conta.numero_agencia = 15;
conta.titular = cliente;
conta.conta = "1010-X";
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("CPF = " + conta.titular.cpf);
Console.WriteLine("Profissao = " + conta.titular.profissao);
Console.WriteLine("Nº da conta = " + conta.conta);
Console.WriteLine("Agencia = " + conta.numero_agencia);
Console.WriteLine("Saldo = " + conta.saldo);