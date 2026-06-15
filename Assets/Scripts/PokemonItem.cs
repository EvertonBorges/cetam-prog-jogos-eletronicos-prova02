public class PokemonItem
{

    public string nome;
    public int poder;
    
    public void Usar(PokemonBag pokemonBag)
    {
        pokemonBag.Curar(poder);    
    }

}