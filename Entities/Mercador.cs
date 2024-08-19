namespace RpgConsole;

public class Mercador() : Iprofissao
{
    public void Trabalhar()
    {
        Console.WriteLine("O Mercador está negociando mercadorias.");
    }

    public void Descansar()
    {
        Console.WriteLine("O Mercador está descansando após um dia de comércio.");
    }

}