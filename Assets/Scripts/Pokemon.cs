using System.Collections.Generic;

public class Pokemon
{
    
    public int id;
    public string nome;
    public int hp;
    public int ataque;
    public int defesa;
    
    public List<PokemonHabilidade> habilidades;
    private Pokemon pokemonEvolucao;

    public Pokemon(int novoId, string novoNome, int novoHp, int novoAtaque, int novaDefesa)
    {
        id = novoId;
        nome = novoNome;
        hp = novoHp;
        ataque = novoAtaque;
        defesa = novaDefesa;

        habilidades = new List<PokemonHabilidade>();
        pokemonEvolucao = null;
    }

    public void SetEvolucao(Pokemon evolucao)
    {
        pokemonEvolucao = evolucao;
    }

    public Pokemon QualMinhaEvolucao()
    {
        return pokemonEvolucao;
    }

    

}