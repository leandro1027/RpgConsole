namespace RpgConsole;

public class Ferreiro() : Iprofissao // classe Ferreiro que implementa a Interface Iprofissao e define as ações especificas de um ferreiro
{
    public void Trabalhar()
    {
        Console.WriteLine("O Ferreiro está forjando uma espada."); // Implementação do método da Inteface Iprofissao
    }
    public void Descansar()
    {
        Console.WriteLine("O Ferreiro está descansando após um dia de trabalho."); // Implementação do método da Inteface Iprofissao

    }
}