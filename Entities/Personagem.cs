namespace RpgConsole;

public abstract class Personagem
{
    public string? Nome { get; set; }
    public Raca Raca { get; set; }
    public Classe Classe { get; set; }
    public Iprofissao? Profissao { get; set; }
    public int Forca { get; set; }
    public int Agilidade { get; set; }
    public int Inteligencia { get; set; }


    public void Atacar(){

    }
    
    public void Defender(){
        
    }
}