int n = int.Parse(Console.ReadLine());
List<int> numeros = new List<int>{0,1};

for(int i= 1; i<n-1; i++)
{
    int numero =numeros[i]+numeros[i-1];
    numeros.Add(numero);
}

Console.WriteLine(string.Join(" ",numeros));

