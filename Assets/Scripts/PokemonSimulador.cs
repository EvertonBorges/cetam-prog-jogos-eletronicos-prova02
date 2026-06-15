using UnityEngine;

public class PokemonSimulador : MonoBehaviour
{

    void Start()
    {
        Pokemon bulbasauro = new Pokemon(1, "Bulbasauro", 45, 49, 49);
        Pokemon ivysauro = new Pokemon(2, "Ivysauro", 60, 62, 63);
        Pokemon venosauro = new Pokemon(3, "Venosauro", 80, 82, 83);
        Pokemon charmander = new Pokemon(4, "Charmander", 39, 52, 43);
        Pokemon charmeleon = new Pokemon(5, "Charmeleon", 58, 64, 58);
        Pokemon charizard = new Pokemon(6, "Charizard", 78, 84, 78);
        Pokemon squirtle = new Pokemon(7, "Squirtle", 44, 48, 65);
        Pokemon wartortle = new Pokemon(8, "Wartortle", 59, 63, 80);
        Pokemon blastoise = new Pokemon(9, "Blastoise", 79, 83, 100);
        Pokemon Caterpie = new Pokemon(10, "Caterpie", 45, 30, 35);
        Pokemon Metapod = new Pokemon(11, "Metapod", 50, 20, 55);
        Pokemon Butterfree = new Pokemon(12, "Butterfree", 60, 45, 50);
        Pokemon Weedle = new Pokemon(13, "Weedle", 40, 35, 30);
        Pokemon Kakuna = new Pokemon(14, "Kakuna", 45, 25, 50);
        Pokemon Beedrill = new Pokemon(15, "Beedrill", 65, 90, 40);
        Pokemon Pidgey = new Pokemon(16, "Pidgey", 40, 45, 40);
        Pokemon Pidgeotto = new Pokemon(17, "Pidgeotto", 63, 60, 55);
        Pokemon Pidgeot = new Pokemon(18, "Pidgeot", 83, 80, 75);
        Pokemon Rattata = new Pokemon(19, "Rattata", 30, 56, 35);
        Pokemon Raticate = new Pokemon(20, "Raticate", 55, 81, 60);
        Pokemon Spearow = new Pokemon(21, "Spearow", 40, 60, 30);
        Pokemon Fearow = new Pokemon(22, "Fearow", 65, 90, 65);
        Pokemon Ekans = new Pokemon(23, "Ekans", 35, 60, 44);
        Pokemon Arbok = new Pokemon(24, "Arbok", 60, 95, 69);
        Pokemon Pikachu = new Pokemon(25, "Pikachu", 35, 55, 40);
        Pokemon Raichu = new Pokemon(26, "Raichu", 60, 90, 55);

        bulbasauro.SetEvolucao(ivysauro);
        ivysauro.SetEvolucao(venosauro);
        charmander.SetEvolucao(charmeleon);
        charmeleon.SetEvolucao(charizard);
        squirtle.SetEvolucao(wartortle);
        wartortle.SetEvolucao(blastoise);
        Caterpie.SetEvolucao(Metapod);
        Metapod.SetEvolucao(Butterfree);
        Weedle.SetEvolucao(Kakuna);
        Kakuna.SetEvolucao(Beedrill);
        Pidgey.SetEvolucao(Pidgeotto);
        Pidgeotto.SetEvolucao(Pidgeot);
        Rattata.SetEvolucao(Raticate);
        Spearow.SetEvolucao(Fearow);
        Ekans.SetEvolucao(Arbok);
        Pikachu.SetEvolucao(Raichu);

        PokemonItemPorcao porcaonormal = new PokemonItemPorcao("PorçãoNormal", 5);
        PokemonItemPorcao porcaosuper = new PokemonItemPorcao("PorçãoSuper", 20);
        PokemonItemPorcao porcaoultra = new PokemonItemPorcao("PorçãoUltra", 50);

        PokemonBag pokemonBag1 = new PokemonBag(charizard);
        PokemonBag pokemonBag2 = new PokemonBag(Fearow);

        PokemonBatalha batalha = new PokemonBatalha(pokemonBag1, pokemonBag2);

        int rodada = 0;

        //rodada 1
        rodada++;
        batalha.Pokemon1Ataca();
       

        //rodada 2 
        rodada++;
        batalha.Pokemon2Ataca();
        
        //rodada 3
        rodada++;
        batalha.Pokemon1Curar(porcaosuper);
        
        //rodada 4
        rodada++;
        batalha.Pokemon2Ataca();


        //rodada 5
        rodada++;
        batalha.Pokemon1Ataca();
     

        //rodada 6
        rodada++;
        batalha.Pokemon2Ataca();
        

        //rodada 7
        rodada++;
        batalha.Pokemon1Ataca();
         

    }

}
