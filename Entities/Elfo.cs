namespace RpgConsole;

public class Elfo : Personagem //Classe Elfo que herda da classe abstrata Personagem
{

    public Elfo()
    {
        Forca = 8;
        Agilidade = 12;
        Inteligencia = 14;
    }

    public override void Atacar(Personagem alvo) // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com seu machado!");
    }

    public override void Defender() // Sobrescrita e implementação do método virtual herdado de Personagem
    {
       Console.WriteLine($"{Nome} usa sua resistência para se defender");
    }
}