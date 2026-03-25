class Agenda
{
    List<Contato> contatos = new List<Contato>();

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
    }

    public void ExibirContatos()
    {
        foreach (var contato in contatos)
        {
            Console.WriteLine(contato.Nome);
        }
    }
}