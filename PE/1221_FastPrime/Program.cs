int numeroEntradas = int.Parse(Console.ReadLine());
for (int i = 0; i< numeroEntradas; i++)
{
    int numero = int.Parse(Console.ReadLine());
    int div = 1;
    bool prime =true;
    for (int j = 1; j<numero; j++)
    {
        if (numero % j == 0)
        {
            div++;
            if (div > 2){
                prime = false;
                break;
            }
            
        }
      

    }
    if (prime){
        Console.WriteLine("Prime");
    }else
    {
        Console.WriteLine("Not Prime");
    }
}