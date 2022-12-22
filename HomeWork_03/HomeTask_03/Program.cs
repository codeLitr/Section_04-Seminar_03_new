// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N:");
int finish = Convert.ToInt32(Console.ReadLine()); 
int start = 1; 

while (start <= finish)
{
    Console.Write(Math.Pow(start,3) + " ");
    start++; 
}