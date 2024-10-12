using System.Globalization;
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

Console.WriteLine("Digite seu nome:");
string name = Console.ReadLine();
Console.WriteLine("Digite seu sálario:");
double salary = double.Parse(Console.ReadLine());
Console.WriteLine("Digite quanto você vendeu:");
double sales = double.Parse(Console.ReadLine());

double total = salary +sales*0.15;

Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));

// Console.WriteLine(total.ToString("#.00"));