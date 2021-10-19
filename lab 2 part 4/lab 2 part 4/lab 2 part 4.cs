Console.WriteLine("Цифровая модель завода");
double Height;
double Length;
double Width;
int Entrance;
int Equipment;
int Lorries;
int People;

double Square;
double Volume;
double Incomelorriesdaily;
double Outcomelorriesdaily;
double AirConditioning;

Console.WriteLine("Введите Height:");
string HeightStr = Console.ReadLine();
Height = Convert.ToDouble(HeightStr);

Console.WriteLine("Введите Length:");
string LengthStr = Console.ReadLine();
Length = Convert.ToDouble(LengthStr);

Console.WriteLine("Введите Width:");
string WidthStr = Console.ReadLine();
Width = Convert.ToDouble(WidthStr);

Console.WriteLine("Введите Entrance:");
string EntranceStr = Console.ReadLine();
Entrance = Convert.ToInt32(EntranceStr);

Console.WriteLine("Введите Equipment:");
string EquipmentStr = Console.ReadLine();
Equipment = Convert.ToInt32(EquipmentStr);

Console.WriteLine("Введите Lorries:");
string LorriesStr = Console.ReadLine();
Lorries = Convert.ToInt32(LorriesStr);

Console.WriteLine("Введите количество People:");
string PeopleStr = Console.ReadLine();
People = Convert.ToInt32(PeopleStr);

Square = Length * Width;
Volume = Square * Height;
Incomelorriesdaily = 0.5 * Square + 0.2 * Volume * Entrance + 0.1 * Equipment + Lorries;
Outcomelorriesdaily = 0.5 * Volume * Entrance + 0.1 * Equipment - Lorries + 0.5 * Square;
AirConditioning = 2 * Volume - 0.6 * Square + 4 * People - 0.85 * Square + 3 * Entrance + Lorries;

Console.WriteLine("Height: " + Height + "м.");
Console.WriteLine("Length: " + Length + "м.");
Console.WriteLine("Height: " + Width + "м.");
Console.WriteLine("Entrance: " + Entrance);
Console.WriteLine("Equipment: " + Equipment);
Console.WriteLine("Lorries: " + Lorries);
Console.WriteLine("People: " + People);
Console.WriteLine("Square: " + Square + "м^2.");
Console.WriteLine("Volume: " + Volume + "м^3.");
Console.WriteLine("Incomelorriesdaily: " + Incomelorriesdaily);
Console.WriteLine("Outcomelorriesdaily: " + Outcomelorriesdaily);
Console.WriteLine("AirConditioning: " + AirConditioning + "м^3.");