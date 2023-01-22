// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

//Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ +

Console.Clear();

double x1, y1, z1, x2, y2, z2 = 0;

System.Console.Write("Введите координату X1: ");
x1 = Convert.ToSingle(Console.ReadLine());
System.Console.Write("Введите координату Y1: ");
y1 = Convert.ToSingle(Console.ReadLine());
System.Console.Write("Введите координату Z1: ");
z1 = Convert.ToSingle(Console.ReadLine());
System.Console.Write("\nВведите координату X2: ");
x2 = Convert.ToSingle(Console.ReadLine());
System.Console.Write("Введите координату Y2: ");
y2 = Convert.ToSingle(Console.ReadLine());
System.Console.Write("Введите координату Z2: ");
z2 = Convert.ToSingle(Console.ReadLine());

Console.Clear();
System.Console.WriteLine("Вы ввели координаты:");
System.Console.SetCursorPosition(4, 1);
System.Console.WriteLine($"X1: {x1}");
System.Console.SetCursorPosition(20, 1);
System.Console.WriteLine($"Y1: {y1}");
System.Console.SetCursorPosition(36, 1);
System.Console.WriteLine($"Z1: {z1}");
System.Console.SetCursorPosition(4, 4);

System.Console.SetCursorPosition(4, 2);
System.Console.WriteLine($"X2: {x2}");
System.Console.SetCursorPosition(20, 2);
System.Console.WriteLine($"Y2: {y2}");
System.Console.SetCursorPosition(36, 2);
System.Console.WriteLine($"Z2: {z2}");
System.Console.SetCursorPosition(0, 4);

double distance = Math.Pow(
                    Math.Pow(x1 - x2, 2) +
                    Math.Pow(y1 - y2, 2) +
                    Math.Pow(z1 - z2, 2), 0.5);
System.Console.WriteLine($"Расстояние между точками: {Math.Round(distance, 2, MidpointRounding.ToZero)}");