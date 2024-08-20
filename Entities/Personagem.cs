namespace RpgConsole;

public abstract class Personagem // Classe abstrata Personagem
{
    public string? Nome { get; set; }
    public Raca Raca { get; set; }
    public Classe Classe { get; set; }
    public Iprofissao? Profissao { get; set; }
    public int Forca { get; set; }
    public int Agilidade { get; set; }
    public int Inteligencia { get; set; }


    public virtual void Atacar(Personagem alvo) 
    { 
    /* Método virtual porque será sobrescritos com override nas classes que herdarem de Personagem. 
    Está passando alvo como parametro, e será implementado nas classes que herdarem */
    }
    
    public virtual void Defender() 
    { 
    /* Método virtual porque será sobrescrito com override nas classes que herdarem de Personagem. 
    Será implementado nas classes que herdarem */
    }
}