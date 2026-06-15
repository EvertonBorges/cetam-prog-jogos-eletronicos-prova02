using UnityEngine;

public class PokemonSimulador : MonoBehaviour
{

    void Start()
    {
        Pokemon pokemon001 = new Pokemon(1, "Bulbasauro", 45, 49, 49);
        Pokemon pokemon002 = new Pokemon(2, "Ivysauro", 60, 62, 63);
        Pokemon pokemon004 = new Pokemon(4, "Charmander", 39, 52, 43);
        Pokemon pokemon005 = new Pokemon(5, "Charmeleon", 58, 64, 58);
        Pokemon pokemon007 = new Pokemon(7, "Squirtle", 44, 48, 65);
        Pokemon pokemon008 = new Pokemon(8, "Wartortle", 59, 63, 80);

        pokemon001.SetEvolucao(pokemon002);
        pokemon004.SetEvolucao(pokemon005);
        pokemon007.SetEvolucao(pokemon008);

        PokemonBag pokemonBag1 = new PokemonBag(pokemon001);
        PokemonBag pokemonBag2 = new PokemonBag(pokemon002);

        PokemonBatalha batalha = new PokemonBatalha(pokemonBag1, pokemonBag2);
    }

}
