namespace RpgConsole;

public class Orc : Personagem
{
    public Orc()
    {
        Forca = 16;
        Agilidade = 7;
        Inteligencia = 8;
    }

    public override void Atacar(Personagem alvo)
    {
       Console.WriteLine($"{Nome} Atacou {alvo.Nome} com brutalidade!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} defendeu os ataques inimigos");
    }
}
