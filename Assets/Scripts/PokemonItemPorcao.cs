using UnityEngine;

public class PokemonItemPorcao : PokemonItem
{

    public PokemonItemPorcao( int novoPoder)
    {
        poder = novoPoder;
    }
    
    public void Usar(PokemonBag pokemon)
    {
        if (!pokemon.vivo)
        {
            Debug.Log("Cura não pode ser usada pois o pokemon " + pokemon.pokemon.nome + " está morto!");
        }
        else
        {
            pokemon.Curar(poder);
        }
    }

}