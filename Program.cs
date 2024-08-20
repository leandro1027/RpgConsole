namespace RpgConsole;

class Program
{
    static void Main(string[] args)
    {
        var gerenciador = new GerenciadorDePersonagem();

        // Criação de personagens
        var guerreiroHumano = gerenciador.CriarPersonagem("Aragorn", Raca.Humano, Classe.Guerreiro, new Ferreiro());
        var magoElfo = gerenciador.CriarPersonagem("Legolas", Raca.Elfo, Classe.Mago, new Alquimista());

        // Exibição das profissões trabalhando
        guerreiroHumano.Profissao.Trabalhar();
        magoElfo.Profissao.Trabalhar();

        // Combate
        var sistemaDeCombate = new SistemaDeCombate();
        sistemaDeCombate.Combater(guerreiroHumano, magoElfo);
    }
}

