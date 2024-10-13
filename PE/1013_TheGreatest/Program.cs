string[] input = Console.ReadLine().Split(' ');
int a = int.Parse(input[0]),b=int.Parse(input[1]), c=int.Parse(input[2]);
int maior = (a+b+Math.Abs(a-b))/2;
maior = (maior+c+Math.Abs(maior-c))/2;

Console.WriteLine(maior + " eh o maior");
