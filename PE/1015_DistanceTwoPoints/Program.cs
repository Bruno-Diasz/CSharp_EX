string [] inputP1 = Console.ReadLine().Split(' ');
string [] inputP2 = Console.ReadLine().Split(' ');
double[] p1= {double.Parse(inputP1[0]), double.Parse(inputP1[1])};
double[] p2= {double.Parse(inputP2[0]), double.Parse(inputP2[1])};
double distance = Math.Sqrt(Math.Pow(p2[0]-p1[0],2)+Math.Pow(p2[1]-p1[1],2));
Console.WriteLine(distance.ToString("F4"));
