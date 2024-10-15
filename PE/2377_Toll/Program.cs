string[] input0 = Console.ReadLine().Split(' ');
string[] input1 = Console.ReadLine().Split(' ');
int estrada = int.Parse(input0[0]), pedagio=int.Parse(input0[1]);
int cpk = int.Parse(input1[0]), pedValor=int.Parse(input1[1]);

int total= estrada / pedagio *pedValor + estrada *cpk;
Console.WriteLine(total);
