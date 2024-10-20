
string[] entrada;
while ((entrada = Console.ReadLine().Split(' ')) != null)
{
    int distancia = int.Parse(entrada[0]);
    int velocidadeFugitivo = int.Parse(entrada[1]);
    int velocidadeGuarda = int.Parse(entrada[2]);
    double limite = 12.0;
    if ((limite/velocidadeFugitivo)<= (limite+distancia)/velocidadeGuarda)
    {
        Console.WriteLine("S");
    }
    else
    {
        Console.WriteLine("N");
    } 
}