public class PokemonItemPorcao : PokemonItem
{
    public int poder;

    // Construtor que passa o nome para a classe pai (base) e define o poder da cura
    public PokemonItemPorcao(string novoNome, int novoPoder) : base(novoNome)
    {
        poder = novoPoder;
    }

    // Sobrescreve o método Usar para aplicar os pontos de cura na PokemonBag
    public override void Usar(PokemonBag pokemon)
    {
        if (pokemon != null)
        {
            pokemon.Curar(poder);
        }
    }
}