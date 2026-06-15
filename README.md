### CETAM - Instituto Benjamin Constant
### Técnico de Nível Médio em Programação de Jogos Digitais
### Programação de Jogos Eletrônicos
### Turma: 2026.1

<br/>

> [!IMPORTANT]
> Para envio da prova, COMPACTE a pasta Assets na raiz do projeto para ZIP e envie para o e-mail: evertonsoaresborges@gmail.com <br/>
> Assunto: Avaliação Parcial 02 CETAM - 2026.1

<br/>

**A Liga Pokémon de Manaus (LPM) iniciou o desenvolvimento de um simulador de batalhas digital com o objetivo de democratizar o acesso de novos treinadores ao circuito competitivo. O projeto encontra-se em estágio de prototipagem técnica, com sua arquitetura de classes fundamental estabelecida no arquivo PokemonSimulador.cs.**<br/><br/>
**Sua responsabilidade consiste em implementar os ajustes técnicos descritos a seguir, assegurando a robustez do código e a eficiência da simulação conforme os padrões de Programação Orientada a Objetos.**</br><br/>

1. Há apenas os 3 pokemons iniciais do jogo criados no código, e as suas evoluções. Agora querem realizar testes com mais pokemons, então crie os objetos para representar os 26 primeiros pokemons. Começando no Bulbasauro e terminando no Raichu. Os dados desses pokemons se encontram no seguinte link: https://shorturl.at/qBSyo (1.5 pontos)
2. Crie as porções para o jogo, com seus respectivos nomes e poderes: (1.0 pontos)
- Porção normal, poder = 5;
- Porção super, poder = 20;
- Porção ultra, poder = 50;
3. Está faltando finalizar o método Pokemon2Ataca dentro da classe PokemonBatalha, finalize-o para que possa realizar as simulações. (1.5 pontos)
4. Corrija a classe PokemonBatalha para que ela identifique quando a batalha é encerrada, ou seja, quando um dos pokemons vencer. (2.0 pontos)
5. Ajuste para que o cálculo de dano considere a defesa do pokemon que está recebendo o dano, ou seja, ele deve receber ((dano do atacante) menos (defesa do defensor)) dividido por 2. Lembrando que sempre há dano quando é feito um ataque, então o defensor deve receber pelo menos 1 de dano. (2.5 pontos)
6. Crie um objeto para representar a batalha e adicione os pokemons Charizard como primeiro pokemon da batalha e o Fearow como segundo pokemon. E simule a seguinte batalha: (1.5 pontos)
- Acontece 4 vezes: Charizard ATACA Fearow; Fearow ATACA Charizard;
- Charizard CURA com Porção super; Fearow ATACA Charizard;
- Acontece 3 vezes: Charizard ATACA Fearow; Fearow ATACA Charizard;
- Charizard ATACA Fearow.<br/>
Neste momento a partida deve mostrar uma mensagem de que Charizard venceu.


