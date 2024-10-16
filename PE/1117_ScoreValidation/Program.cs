float nota1 = -0.1f;
float nota2 = -0.1f;
while (true){
    nota1 = float.Parse(Console.ReadLine());
    if (nota1 <0 ||nota1 >10)
    {
        Console.WriteLine("nota invalida");
    }
    else
    {
        break;
    }
}
while (true)
{
    nota2 = float.Parse(Console.ReadLine());
    if (nota2 <0 ||nota2 >10)
    {
        Console.WriteLine("nota invalida");
    }
    else
    {
        break;
    }
}

Console.WriteLine("media = "+ ((nota1+nota2)/2).ToString("f2"));