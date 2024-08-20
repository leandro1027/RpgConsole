# RpgConsole
RPG em modo console onde o jogador pode criar personagens com base em diferentes raças, classes e profissões. Projeto em C# utilizando os conceitos de POO aprendidos em sala de aula.

## Principais Funcionalidades


1. **Criação de Personagens:**
   - Permite criar personagens personalizados escolhendo nome, raça (Humano, Elfo, Anão, Orc), classe (Guerreiro, Mago, Arqueiro) e profissão (Ferreiro, Alquimista, Mercador).


2. **Sistema de Combate:**
   - Dois personagens podem lutar entre si, com base em atributos como força, agilidade e inteligência. O combate é simples e focado em demonstrar o uso de métodos e interações entre objetos.


3. **Gerenciamento de Profissões:**
   - Cada personagem pode ter uma profissão, que define habilidades específicas, como `Trabalhar()` e `Descansar()`.

## Conceitos de Programação Orientada a Objetos (POO)


1. **Herança:**
   - A classe abstrata `Personagem` serve como base para diferentes raças (Humano, Elfo, Anão, Orc), permitindo que cada raça tenha atributos e comportamentos específicos.


2. **Classe Abstrata:**
   - `Personagem` é uma classe abstrata que define métodos como `Atacar()` e `Defender()`, que são implementados nas classes derivadas (Humano, Elfo, etc.).


3. **Interface:**
   - A interface `IProfissao` é implementada por várias classes de profissão (Ferreiro, Alquimista, Mercador), garantindo que todas as profissões tenham métodos comuns como `Trabalhar()` e `Descansar()`.


4. **Polimorfismo:**
   - O polimorfismo é utilizado através da interface `IProfissao` e da classe abstrata `Personagem`, permitindo que diferentes tipos de profissões e personagens sejam tratados de maneira uniforme.


5. **Enumerações (Enums):**
   - `Raca` e `Classe` são definidos como enums, facilitando a escolha de raças e classes ao criar personagens.


## Execução do Sistema


1. Certifique-se de ter o .NET instalado em seu ambiente.
2. Compile o código-fonte utilizando um ambiente de desenvolvimento como o Visual Studio, ou diretamente pelo terminal com o comando:
   ```sh
   dotnet build
   ```
3. Após a compilação, execute o programa com:
   ```sh
   dotnet run
   ```


