namespace RpgConsole;

public class Elfo : Personagem
{

    public Elfo()
    {
        Forca = 8;
        Agilidade = 12;
        Inteligencia = 14;
    }

    public override void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com seu machado!");
    }

    public override void Defender()
    {
       Console.WriteLine($"{Nome} usa sua resistência para se defender");
    }
}