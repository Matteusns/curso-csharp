using bytebank.Contas;
using bytebank.Titular;

ContaCorrente conta = new ContaCorrente(18, "1010-X");
conta.Saldo = 500;
conta.Titular = new Cliente();

ContaCorrente conta2 = new ContaCorrente(18, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta3 = new ContaCorrente(18, "1525-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);