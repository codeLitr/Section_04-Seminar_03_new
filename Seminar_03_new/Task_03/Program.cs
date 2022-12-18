/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) => 5
// Math.Pow (2, 3) => 8 = 2 * 2 * 2
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Math.Pow(число, степень)
// Math.Round(число, количество знаков) 
Console.WriteLine("Расстояние между 2 точками: " + Math.Round(d));
// A (3,6); B (2,1) -> 5,09
*/

// 2 вариант:

Console.Write("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) => 5
// Math.Pow (2, 3) => 8 = 2 * 2 * 2
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Math.Pow(число, степень)
// Math.Round(число, количество знаков) 
Console.WriteLine("Расстояние между 2 точками:" + x1 + "," + y1 + "," + x2 + "," + y2 + " = " + d ); // Конкатенация: "1" + "2" = "12"
// A (3,6); B (2,1) -> 5,09 
// $ = Shift + 4 на англ. раскладке
Console.WriteLine($"Расстояние между 2 точками: {x1},{y1}, {x2},{y2} = {Math.Round(d,3)}"); // Интерполяция
