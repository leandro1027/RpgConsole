namespace RpgConsole;

using System;

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDePersonagem gerenciador = new GerenciadorDePersonagem();

        Console.WriteLine("Criação do Personagem 1");
        Personagem personagem1 = CriarPersonagem(gerenciador);

        Console.WriteLine("\nCriação do Personagem 2");
        Personagem personagem2 = CriarPersonagem(gerenciador);

        SistemaDeCombate sistemaDeCombate = new SistemaDeCombate();
        sistemaDeCombate.Combater(personagem1, personagem2);
    }

    static Personagem CriarPersonagem(GerenciadorDePersonagem gerenciador)
    {
        Console.Write("Digite o nome do personagem: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Escolha uma raça:");
        foreach (var raca in Enum.GetValues(typeof(Raca)))
        {
            Console.WriteLine($"{(int)raca}. {raca}");
        }
        Raca racaEscolhida = (Raca)int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma classe:");
        foreach (var classe in Enum.GetValues(typeof(Classe)))
        {
            Console.WriteLine($"{(int)classe}. {classe}");
        }
        Classe classeEscolhida = (Classe)int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha uma profissão:");
        Console.WriteLine("1. Ferreiro");
        Console.WriteLine("2. Alquimista");
        Console.WriteLine("3. Mercador");
        int profissaoEscolhida = int.Parse(Console.ReadLine());

        Iprofissao profissao = null;
        switch (profissaoEscolhida)
        {
            case 1:
                profissao = new Ferreiro();
                break;
            case 2:
                profissao = new Alquimista();
                break;
            case 3:
                profissao = new Mercador();
                break;
        }

        return gerenciador.CriarPersonagem(nome, racaEscolhida, classeEscolhida, profissao);
    }
}

