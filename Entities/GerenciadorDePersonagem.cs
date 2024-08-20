namespace RpgConsole;

public class GerenciadorDePersonagem
{
    public Personagem CriarPersonagem(string nome, Raca raca, Classe classe, Iprofissao profissao)
    {
        Personagem personagem = null;

        switch (raca)
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

        personagem.Nome = nome;
        personagem.Classe = classe;
        personagem.Profissao = profissao;

        return personagem;
    }
}


