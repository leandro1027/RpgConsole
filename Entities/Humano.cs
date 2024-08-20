namespace RpgConsole;

public class Humano : Personagem // Classe Humano que herda da classe abstrata Personagem
{
      public Humano(){
        Forca = 9;
        Agilidade = 12;
        Inteligencia = 13;
    }

     public override void Atacar(Personagem alvo) // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com força de {Forca}");
    }

    public override void Defender() // Sobrescrita e implementação do método virtual herdado de Personagem
    {
        Console.WriteLine($"{Nome} defende!");
    }

}
