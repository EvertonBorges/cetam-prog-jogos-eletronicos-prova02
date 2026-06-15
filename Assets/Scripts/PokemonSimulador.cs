using UnityEngine;

public class PokemonSimulador : MonoBehaviour
{

    void Start()
    {
        Pokemon pokemon001 = new Pokemon(1, "Bulbasauro", 45, 49, 49);
        Pokemon pokemon002 = new Pokemon(2, "Ivysauro", 60, 62, 63);
        Pokemon pokemon003 = new Pokemon(3, "Venosauro", 80, 82, 83);
        Pokemon pokemon004 = new Pokemon(4, "Charmander", 39, 52, 43);
        Pokemon pokemon005 = new Pokemon(5, "Charmeleon", 58, 64, 58);
        Pokemon pokemon006 = new Pokemon(6, "Charizard", 78, 84, 78);
        Pokemon pokemon007 = new Pokemon(7, "Squirtle", 44, 48, 65);
        Pokemon pokemon008 = new Pokemon(8, "Wartortle", 59, 63, 80);
        Pokemon pokemon009 = new Pokemon(9, "Blastoise", 79, 83, 100);
        Pokemon pokemon010 = new Pokemon(10, "Cartepie", 45, 30, 35);
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

        PokemonItemPorcao porcaoNormal = new PokemonItemPorcao("Normal", 5);
        PokemonItemPorcao porcaoSuper = new PokemonItemPorcao("Super", 20);
        PokemonItemPorcao porcaoUltra = new PokemonItemPorcao("Ultra", 50);


        PokemonBag pokemonBag1 = new PokemonBag(pokemon006);
        PokemonBag pokemonBag2 = new PokemonBag(pokemon022);

        

        PokemonBatalha batalha = new PokemonBatalha(pokemonBag1, pokemonBag2);
        //int rodada = 0;
       
        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();
        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();
        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();

        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();

        
        porcaoSuper.Usar(pokemonBag1);
        batalha.Pokemon2Ataca();

        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();
        
        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();

        
        batalha.Pokemon1Ataca();
        batalha.Pokemon2Ataca();

        
        batalha.Pokemon1Ataca();
        batalha.ChecaVitoria();


    }

}



// //ID	Nome	HP	Ataque	Defesa	Evolução
// 1	Bulbasauro	45	49	49	Ivysauro
// 2	Ivysauro	60	62	63	Venosauro
// 3	Venosauro	80	82	83	
// 4	Charmander	39	52	43	Charmeleon
// 5	Charmeleon	58	64	58	Charizard
// 6	Charizard	78	84	78	
// 7	Squirtle	44	48	65	Wartortle
// 8	Wartortle	59	63	80	Blastoise
// 9	Blastoise	79	83	100	
// 10	Caterpie	45	30	35	Metapod
// 11	Metapod	50	20	55	Butterfree
// 12	Butterfree	60	45	50	
// 13	Weedle	40	35	30	Kakuna
// 14	Kakuna	45	25	50	Beedrill
// 15	Beedrill	65	90	40	
// 16	Pidgey	40	45	40	Pidgeotto
// 17	Pidgeotto	63	60	55	Pidgeotto
// 18	Pidgeotto	83	80	75	
// 19	Rattata	30	56	35	Raticate
// 20	Raticate	55	81	60	
// 21	Spearow	40	60	30	Fearow
// 22	Fearow	65	90	65	
// 23	Ekans	35	60	44	Arbok
// 24	Arbok	60	95	69	
// 25	Pikachu	35	55	40	Raichu
// 26	Raichu	60	90	55	