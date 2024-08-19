namespace RpgConsole;

public class Humano : Personagem
{
      public Humano(){
        Forca = 9;
        Agilidade = 12;
        Inteligencia = 13;
    }

     public override void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{Nome} ataca {alvo.Nome} com força de {Forca}");
    }

    public override void Defender()
    {
        Console.WriteLine($"{Nome} defende!");
    }

}
