namespace RpgConsole;


public class SistemaDeCombate
{
    public void Combater(Personagem p1, Personagem p2) 
    {
        Console.WriteLine($"{p1.Nome} (Força: {p1.Forca}, Agilidade: {p1.Agilidade}) VS {p2.Nome} (Força: {p2.Forca}, Agilidade: {p2.Agilidade})");

        p1.Atacar(p2);
        p2.Defender();

        p2.Atacar(p1);
        p1.Defender();

       
        if (p1.Forca > p2.Forca)  // Lógica de combate, no if é verificado quem tem mais força, quem tiver vence a batalha.
        {
            Console.WriteLine($"{p1.Nome} venceu a batalha!");
        }
        else if (p1.Forca < p2.Forca)
        {
            Console.WriteLine($"{p2.Nome} venceu a batalha!");
        }
        else
        {
            Console.WriteLine("A batalha terminou em empate!");
        }
    }
}



