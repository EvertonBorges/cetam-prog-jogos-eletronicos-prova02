using UnityEngine;

public class PokemonBatalha
{

    private PokemonBag pokemon1;
    private PokemonBag pokemon2;

    private int rodada;

    public PokemonBatalha(PokemonBag novoPokemon1, PokemonBag novoPokemon2)
    {
        pokemon1 = novoPokemon1;
        pokemon2 = novoPokemon2;

        rodada = 0;
    }

    public void Fugir()
    {
        pokemon1 = null;
        pokemon2 = null;
    }

    private void PartidaEncerrada(PokemonBag pokemonVitoria)
    {
        Debug.Log("Fim de partida, " + pokemonVitoria.pokemon.nome + " venceu!!!");
        pokemon1 = null;
        pokemon2 = null;
    }

    public void Pokemon1Ataca()
    {
        pokemon1.Ataca(pokemon2);
        string evento = pokemon1.pokemon.nome + " ataca o " + pokemon2.pokemon.nome;
        ImprimeDadosDeBatalha(evento);
        ChecaVitoria();
    }

    public void Pokemon2Ataca() 
    {
        pokemon2.Ataca(pokemon1);
        string evento =  pokemon2.pokemon.nome + " ataca o " + pokemon1.pokemon.nome;
        ImprimeDadosDeBatalha(evento);
        ChecaVitoria();
    }

    private void ChecaVitoria()
    {
        if (!pokemon1.vivo)
            PartidaEncerrada(pokemon2);
        else if (!pokemon2.vivo)
            PartidaEncerrada(pokemon1);
    }

    public void Pokemon1Curar(PokemonItemPorcao porcao)
    {
        porcao.Usar(pokemon1);
        string evento = pokemon1.pokemon.nome + " usou porção de cura (" + porcao.nome + ")";
        ImprimeDadosDeBatalha(evento);
    }
    
    private void ImprimeDadosDeBatalha(string evento)
    {
        rodada++;

        Debug.Log("================= Rodada " + rodada + " =================");
        Debug.Log(evento);
        pokemon1.ImprimeDadosDeBatalha();
        pokemon2.ImprimeDadosDeBatalha();
    }

}