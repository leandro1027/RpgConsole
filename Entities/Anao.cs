namespace RpgConsole;

public class Anao : Personagem //Classe Anao que herda da classe abstrata Personagem
{
    public Anao()
    {
        Forca = 12;
        Agilidade = 8;
        Inteligencia = 10;
    }

    public override void Atacar(Personagem alvo) // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com força de {Forca}");
    }

    public override void Defender() // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} Usa sua resistência para defender");
    }
}