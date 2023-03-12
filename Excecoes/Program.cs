using csharp_exception.Titular;
using csharp_exception.Contas;
using Excecoes;

LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida!");
}
finally
{
    leitor.Dispose();
}

/*
try
{
    ContaCorrente conta1 = new ContaCorrente(1, "1234-X");
    // Saque maior que o tem em conta.
    conta1.Sacar(150);

}
catch (ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro " + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine();
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine();
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Operação inválida! Saldo insuficiente.");
    Console.WriteLine(ex.Message);
}

*/