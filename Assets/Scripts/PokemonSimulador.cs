using UnityEngine;

public class PokemonSimulador : MonoBehaviour
{
    void Start()
    {
        // ==========================================
        // REQUISITO 1: Inicialização dos 26 Pokémons
        // ==========================================
        Pokemon pokemon001 = new Pokemon(1, "Bulbasauro", 45, 49, 49);
        Pokemon pokemon002 = new Pokemon(2, "Ivysauro", 60, 62, 63);
        Pokemon pokemon003 = new Pokemon(3, "Venusauro", 80, 82, 83);
        Pokemon pokemon004 = new Pokemon(4, "Charmander", 39, 52, 43);
        Pokemon pokemon005 = new Pokemon(5, "Charmeleon", 58, 64, 58);
        Pokemon pokemon006 = new Pokemon(6, "Charizard", 78, 84, 78);
        Pokemon pokemon007 = new Pokemon(7, "Squirtle", 44, 48, 65);
        Pokemon pokemon008 = new Pokemon(8, "Wartortle", 59, 63, 80);
        Pokemon pokemon009 = new Pokemon(9, "Blastoise", 79, 83, 100);
        Pokemon pokemon010 = new Pokemon(10, "Caterpie", 45, 30, 35);
        Pokemon pokemon011 = new Pokemon(11, "Metapod", 50, 20, 55);
        Pokemon pokemon012 = new Pokemon(12, "Butterfree", 60, 45, 50);
        Pokemon pokemon013 = new Pokemon(13, "Weedle", 40, 35, 30);
        Pokemon pokemon014 = new Pokemon(14, "Kakuna", 45, 25, 50);
        Pokemon pokemon015 = new Pokemon(15, "Beedrill", 65, 90, 40);
        Pokemon pokemon016 = new Pokemon(16, "Pidgey", 40, 45, 40);
        Pokemon pokemon017 = new Pokemon(17, "Pidgeotto", 63, 60, 55);
        Pokemon pokemon018 = new Pokemon(18, "Pidgeot", 83, 80, 75); 
        Pokemon pokemon019 = new Pokemon(19, "Rattata", 30, 56, 35);
        Pokemon pokemon020 = new Pokemon(20, "Raticate", 55, 81, 60);
        Pokemon pokemon021 = new Pokemon(21, "Spearow", 40, 60, 30);
        Pokemon pokemon022 = new Pokemon(22, "Fearow", 65, 90, 65);
        Pokemon pokemon023 = new Pokemon(23, "Ekans", 35, 60, 44);
        Pokemon pokemon024 = new Pokemon(24, "Arbok", 60, 95, 69);
        Pokemon pokemon025 = new Pokemon(25, "Pikachu", 35, 55, 40);
        Pokemon pokemon026 = new Pokemon(26, "Raichu", 60, 90, 55);

        // Configuração das Evoluções
        pokemon001.SetEvolucao(pokemon002);
        pokemon002.SetEvolucao(pokemon003);
        pokemon004.SetEvolucao(pokemon005);
        pokemon005.SetEvolucao(pokemon006);
        pokemon007.SetEvolucao(pokemon008);
        pokemon008.SetEvolucao(pokemon009);
        pokemon010.SetEvolucao(pokemon011);
        pokemon011.SetEvolucao(pokemon012);
        pokemon013.SetEvolucao(pokemon014);
        pokemon014.SetEvolucao(pokemon015);
        pokemon016.SetEvolucao(pokemon017);
        pokemon017.SetEvolucao(pokemon018);
        pokemon019.SetEvolucao(pokemon020);
        pokemon021.SetEvolucao(pokemon022);
        pokemon023.SetEvolucao(pokemon024);
        pokemon025.SetEvolucao(pokemon026);

        // ==========================================
        // REQUISITO 2: Criação das Poções
        // ==========================================
        PokemonItemPorcao porcaoSuper = new PokemonItemPorcao("Porção super", 20);

        // ==========================================
        // REQUISITO 6: Preparação da Batalha (Linhas 56-60 corrigidas)
        // ==========================================
        PokemonBag pokemonBag1 = new PokemonBag(pokemon006); // Charizard
        PokemonBag pokemonBag2 = new PokemonBag(pokemon022); // Fearow

        PokemonBatalha batalha = new PokemonBatalha(pokemonBag1, pokemonBag2);

        // ==========================================
        // SIMULAÇÃO CRONOLÓGICA PASSO A PASSO
        // ==========================================
        // Rodada 1
        batalha.Pokemon1Ataca();

        // Rodada 2
        batalha.Pokemon2Ataca();

        // Rodada 3
        batalha.Pokemon1Ataca();

        // Rodada 4
        batalha.Pokemon2Ataca();

        // Rodada 5
        batalha.Pokemon1Ataca();

        // Rodada 6
        batalha.Pokemon2Ataca();

        // Rodada 7
        batalha.Pokemon1Ataca();

        // Rodada 8
        batalha.Pokemon2Ataca();

        // Rodada 9 (Cura estratégica)
        batalha.Pokemon1Curar(porcaoSuper);

        // Rodada 10
        batalha.Pokemon2Ataca();

        // Rodada 11
        batalha.Pokemon1Ataca();

        // Rodada 12
        batalha.Pokemon2Ataca();

        // Rodada 13
        batalha.Pokemon1Ataca();

        // Rodada 14
        batalha.Pokemon2Ataca();

        // Rodada 15
        batalha.Pokemon1Ataca();

        // Rodada 16
        batalha.Pokemon2Ataca();

        // Rodada 17 (Vitória)
        batalha.Pokemon1Ataca();
    }
}