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
        pokemonBatalha.RecebeDano(pokemon.ataque - pokemon.defesa / 2);
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




//    switch (pokemon)
//                 {
                    
//                     case 1:
//                         dano = pokemon1.ataque - pokemon2.defesa/2;
//                         break;
//                     case 2:
//                         dano = pokemon2.ataque - pokemon1.defesa/2;
//                         break;
//                     default;
//                     {
//                         dano = hp - 1;
//                     }
//                 }