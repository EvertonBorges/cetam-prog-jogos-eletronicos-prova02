using UnityEngine;

public class PokemonBag
{
    
    public Pokemon pokemon;
    public int hp;
    public int hpTotal;
    public bool vivo;

    public PokemonBag(Pokemon novoPokemon)
    {
        pokemon = novoPokemon;
        hp = novoPokemon.hp;
        hpTotal = novoPokemon.hp;
        vivo = true;
    }

    public void Curar(int quantidadeDeCura)
    {
        if (!vivo)
        {
            Debug.Log("Pokemon " + pokemon.nome + " está morto");
        }
        else
        {
            hp = hp + quantidadeDeCura;

            if (hp > hpTotal)
            {
                hp = hpTotal;
            }
        }
    }

    public void RecebeDano(int dano)
    {
        if (!vivo)
            Debug.Log("Pokemon " + pokemon.nome + " está morto");
        else
        {
            hp = hp - dano;

            if (hp < 0)
            {
                hp = 0;
                vivo = false;
                Debug.Log("Pokemon: " + pokemon.nome + " morreu");
            }
        }
    }

    public void Ataca(PokemonBag pokemonBatalha)
    {
        int dano = (pokemon.ataque - pokemonBatalha.pokemon.defesa) / 2;

        if (dano < 1)
        {
            dano = 1;
        }

        pokemonBatalha.RecebeDano(dano);
    }

    public void ImprimeDadosDeBatalha()
    {
        Debug.Log(
            "Pokemon : " + pokemon.nome + "\n" + 
            "HP: " + hp + "\n" +
            "Ataque: " + pokemon.ataque + "\n" +
            "Defesa: " + pokemon.defesa
        );
    }

}