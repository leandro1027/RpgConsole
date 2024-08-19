namespace RpgConsole;

public class Anao : Personagem
{
    public Anao()
    {
        Forca = 14;
        Agilidade = 8;
        Inteligencia = 6;
    }

    public override void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com força de {Forca}");
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} Usa sua resistência para defender");
    }
}