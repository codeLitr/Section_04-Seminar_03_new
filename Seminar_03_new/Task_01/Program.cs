/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

System.Console.WriteLine("Введите координату по оси оX: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());

// 1: ++
if (x > 0 && y > 0 )
{
    Console.WriteLine("I четверть");
}
// 2: -+
else if (x < 0 && y > 0 )
{
    Console.WriteLine("II четверть");
}
// 3: --
else if (x < 0 && y < 0 )
{
    Console.WriteLine("III четверть");
}
// 4: +-
else if (x > 0 && y < 0 )
{
    Console.WriteLine("IV четверть");
}

