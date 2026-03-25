internal class Emprestimo{
    public Livro Livro { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataPrevista { get; set; }
    public DateTime DataDevolucaoReal { get; set; }

    public double CalcularMulta()
    {
        if (DataDevolucaoReal > DataPrevista)
        {
            int diasAtraso = (DataDevolucaoReal - DataPrevista).Days;
            return diasAtraso * 0.5; 
        }
        return 0;
    }
}
