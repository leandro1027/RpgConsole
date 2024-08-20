namespace RpgConsole;

public class Alquimista() : Iprofissao // classe Alquimista que implementa a Interface Iprofissao e define as ações especificas de um alquimista
{
    public void Trabalhar()
    {
        System.Console.WriteLine("alquimista está criando uma poção."); // Implementação do método da Inteface Iprofissao
    }

      public void Descansar()
    {
        Console.WriteLine("O Alquimista está descansando após um dia de experimentos."); // Implementação do método da Inteface Iprofissao
    }

}