namespace RpgConsole;

public class Mercador : Iprofissao // classe Mercador que implementa a Interface Iprofissao e define as ações especificas de um mercador
{
    public void Trabalhar()
    {
        Console.WriteLine("O Mercador está negociando mercadorias."); // Implementação do método da Inteface Iprofissao
    }

    public void Descansar()
    {
        Console.WriteLine("O Mercador está descansando após um dia de comércio."); // Implementação do método da Inteface Iprofissao
    }

}