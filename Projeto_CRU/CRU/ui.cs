namespace CRU;

public class UI
{
    public static int Menu(){
        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine(" 1 - Inserir, 2 - Listar, 3 - Atualizar, 4 - Excluir, 9 - Fim");
        Console.Write("Informe uma opção: ");
        return int.Parse(Console.ReadLine());
    }
}
