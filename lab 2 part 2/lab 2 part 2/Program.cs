double x, f;
x = double.Parse(Console.ReadLine());
f = (1 / 19.0) + Math.Log(Math.Abs(x) / 2) + x / 3 + Math.Max(x / 4, 2) + Math.Sin(1 / 3) + Math.Pow(x, 2 * x) - 1;
Console.WriteLine($"Переменная: {x}");
Console.WriteLine($"Переменная: {f}");
Console.ReadKey();