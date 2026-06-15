public abstract class PokemonItem
{
    public string nome;

    public PokemonItem(string novoNome)
    {
        nome = novoNome;
    }

    public abstract void Usar(PokemonBag pokemon);
}