double x, y, z, f;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
z = double.Parse(Console.ReadLine());
f = (1 / 19.0) + Math.Log(Math.Abs(y) / 2) + z / 3 + Math.Max(x / 4, 2);
Console.WriteLine(f);
Console.ReadKey();