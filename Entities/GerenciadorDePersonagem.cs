namespace RpgConsole;

public class GerenciadorDePersonagem // Classe que gerencia a criação de personagens 
{
    public Personagem CriarPersonagem(string nome, Raca raca, Classe classe, Iprofissao profissao) // Método pra criar um personagem, recebe os parametros  nome, raca, 
    {                                                                                              // classe e profissao e retorna um objeto Personagem configurado
        Personagem personagem = null; 

        switch (raca) // Criação do Personagem de acordo com a raça
        {
            case Raca.Humano:
                personagem = new Humano();
                break;
            case Raca.Elfo:
                personagem = new Elfo();
                break;
            case Raca.Anao:
                personagem = new Anao();
                break;
            case Raca.Orc:
                personagem = new Orc();
                break;
        }

        personagem.Nome = nome; // Config das propriedades do Personagem
        personagem.Classe = classe;
        personagem.Profissao = profissao;

        return personagem;
    }
}


