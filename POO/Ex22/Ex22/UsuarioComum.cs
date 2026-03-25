class UsuarioComum : Usuarios
{
    public override bool PodeExcluir()
    {
        return false;
    }
}