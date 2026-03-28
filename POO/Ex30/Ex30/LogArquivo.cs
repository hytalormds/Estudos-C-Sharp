public class LogArquivo : ILogger
{
    public void Registrar(string messagem)
    {
        Console.WriteLine(messagem);
    }
}