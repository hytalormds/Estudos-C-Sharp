public class LogBanco : ILogger
{
    public void Registrar(string messagem)
    {
        Console.WriteLine(messagem);
    }
}