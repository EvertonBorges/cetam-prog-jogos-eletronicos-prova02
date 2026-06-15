using UnityEngine;
using System.Collections.Generic;

public class PokemonSimulador : MonoBehaviour
{
    void Start()
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        Pokemon bulbasaur = new Pokemon(1, "Bulbasaur", 45, 49, 49);
        Pokemon ivysaur = new Pokemon(2, "Ivysaur", 60, 62, 63);
        Pokemon venusaur = new Pokemon(3, "Venusaur", 80, 82, 83);

        Pokemon charmander = new Pokemon(4, "Charmander", 39, 52, 43);
        Pokemon charmeleon = new Pokemon(5, "Charmeleon", 58, 64, 58);
        Pokemon charizard = new Pokemon(6, "Charizard", 78, 84, 78);

        Pokemon squirtle = new Pokemon(7, "Squirtle", 44, 48, 65);
        Pokemon wartortle = new Pokemon(8, "Wartortle", 59, 63, 80);
        Pokemon blastoise = new Pokemon(9, "Blastoise", 79, 83, 100);

        Pokemon caterpie = new Pokemon(10, "Caterpie", 45, 30, 35);
        Pokemon metapod = new Pokemon(11, "Metapod", 50, 20, 55);
        Pokemon butterfree = new Pokemon(12, "Butterfree", 60, 45, 50);

        Pokemon weedle = new Pokemon(13, "Weedle", 40, 35, 30);
        Pokemon kakuna = new Pokemon(14, "Kakuna", 45, 25, 50);
        Pokemon beedrill = new Pokemon(15, "Beedrill", 65, 90, 40);

        Pokemon pidgey = new Pokemon(16, "Pidgey", 40, 45, 40);
        Pokemon pidgeotto = new Pokemon(17, "Pidgeotto", 63, 60, 55);
        Pokemon pidgeot = new Pokemon(18, "Pidgeot", 83, 80, 75);

        Pokemon rattata = new Pokemon(19, "Rattata", 30, 56, 35);
        Pokemon raticate = new Pokemon(20, "Raticate", 55, 81, 60);

        Pokemon spearow = new Pokemon(21, "Spearow", 40, 60, 30);
        Pokemon fearow = new Pokemon(22, "Fearow", 65, 90, 65);

        Pokemon ekans = new Pokemon(23, "Ekans", 35, 60, 44);
        Pokemon arbok = new Pokemon(24, "Arbok", 60, 95, 69);

        Pokemon pikachu = new Pokemon(25, "Pikachu", 35, 55, 40);
        Pokemon raichu = new Pokemon(26, "Raichu", 60, 90, 55);

        // Evolução
        bulbasaur.SetEvolucao(ivysaur);
        ivysaur.SetEvolucao(venusaur);

        charmander.SetEvolucao(charmeleon);
        charmeleon.SetEvolucao(charizard);

        squirtle.SetEvolucao(wartortle);
        wartortle.SetEvolucao(blastoise);

        caterpie.SetEvolucao(metapod);
        metapod.SetEvolucao(butterfree);

        weedle.SetEvolucao(kakuna);
        kakuna.SetEvolucao(beedrill);

        pidgey.SetEvolucao(pidgeotto);
        pidgeotto.SetEvolucao(pidgeot);

        rattata.SetEvolucao(raticate);
        spearow.SetEvolucao(fearow);
        ekans.SetEvolucao(arbok);
        pikachu.SetEvolucao(raichu);

        // Lista de Pokémon
        pokemons.AddRange(new List<Pokemon>
        {
            bulbasaur, ivysaur, venusaur,
            charmander, charmeleon, charizard,
            squirtle, wartortle, blastoise,
            caterpie, metapod, butterfree,
            weedle, kakuna, beedrill,
            pidgey, pidgeotto, pidgeot,
            rattata, raticate,
            spearow, fearow,
            ekans, arbok,
            pikachu, raichu
        });

        // Itens
        PokemonItemPorcao porcaoNormal = new PokemonItemPorcao("Porção Normal", 5);
        PokemonItemPorcao porcaoSuper = new PokemonItemPorcao("Porção Super", 20);
        PokemonItemPorcao porcaoUltra = new PokemonItemPorcao("Porção Ultra", 50);

        Debug.Log("Item criado: " + porcaoNormal.nome + " - Poder: " + porcaoNormal.poder);
        Debug.Log("Item criado: " + porcaoSuper.nome + " - Poder: " + porcaoSuper.poder);
        Debug.Log("Item criado: " + porcaoUltra.nome + " - Poder: " + porcaoUltra.poder);

        Debug.Log("Total de Pokémon cadastrados: " + pokemons.Count);

        foreach (Pokemon pokemon in pokemons)
        {
            Debug.Log("Pokémon #" + pokemon.id + " - " + pokemon.nome);
        }

    
        Pokemon charizardBattle = charizard;
        Pokemon fearowBattle = fearow;

        int hpCharizard = charizardBattle.hp;
        int hpFearow = fearowBattle.hp;

        // Poção usada na batalha
        int curaSuper = porcaoSuper.poder;

        // 4 rodadas
        for (int i = 0; i < 4; i++)
        {
            hpFearow -= charizardBattle.ataque;
            hpCharizard -= fearowBattle.ataque;

            hpCharizard += curaSuper;

            hpCharizard -= fearowBattle.ataque;
        }

        // 3 rodadas finais
        for (int i = 0; i < 3; i++)
        {
            hpFearow -= charizardBattle.ataque;
            hpCharizard -= fearowBattle.ataque;
        }

        // Resultado final
        Debug.Log("HP final Charizard: " + hpCharizard);
        Debug.Log("HP final Fearow: " + hpFearow);
    }
}