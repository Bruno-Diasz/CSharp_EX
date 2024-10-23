
string input = Console.ReadLine();
while (!string.IsNullOrEmpty(input ))
{
    string[] entrada = input.Split(" ");
    int distancia = int.Parse(entrada[0]);
    int velocidadeFugitivo = int.Parse(entrada[1]);
    int velocidadeGuarda = int.Parse(entrada[2]);
    double limite = 12.0;
    if ((limite/velocidadeFugitivo)>= (limite+distancia)/velocidadeGuarda)
    {
        Console.WriteLine("S");
    }
    else
    {
        Console.WriteLine("N");
    } 
    input = Console.ReadLine();
}