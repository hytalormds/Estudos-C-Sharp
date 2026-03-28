public class LogConsole : ILogger
{
    public void Registrar(string messagem)
    {
        Console.WriteLine(messagem);
    }
}