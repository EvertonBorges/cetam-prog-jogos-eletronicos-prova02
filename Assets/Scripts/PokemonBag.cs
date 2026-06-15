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
        {
            Debug.Log("Pokemon " + pokemon.nome + " está morto");
        }
        else
        {
            hp = hp - dano;

            if (hp <= 0)
            {
                hp = 0;
                vivo = false;
                Debug.Log("Pokemon: " + pokemon.nome + " morreu");
            }
        }
    }

    // Requisito 5: Fórmula de dano com mitigação por defesa e dano mínimo de 1
    public void Ataca(PokemonBag pokemonBatalha)
    {
        int danoCalculado = (this.pokemon.ataque - pokemonBatalha.pokemon.defesa) / 2;

        if (danoCalculado < 1)
        {
            danoCalculado = 1;
        }

        pokemonBatalha.RecebeDano(danoCalculado);
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