namespace RpgConsole;

public class Orc : Personagem //Classe Orc que herda da classe abstrata Personagem
{
    public Orc()
    {
        Forca = 16;
        Agilidade = 7;
        Inteligencia = 8;
    }

    public override void Atacar(Personagem alvo) // Sobrescrita e implementação do método virtual herdado de Personagem
    {
       Console.WriteLine($"{Nome} Atacou {alvo.Nome} com brutalidade!");
    }

    public override void Defender() // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} defendeu os ataques inimigos");
    }
}
