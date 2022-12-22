// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> Нет
// 12821 -> Да
// 23432 -> Да

ВАРИАНТ РЕШЕНИЯ 1:
int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}
int temp = Prompt("Введите пятизначное число: ");
if (temp < 10000 || temp > 99999)
{
    Console.WriteLine("Вы ввели некорректное число");
}
else
{
    string str = temp.ToString();
    int[] palindrom = new int[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        palindrom[i] = int.Parse(str[i].ToString());
    }
    if (palindrom[0] == palindrom[4] && palindrom[1] == palindrom[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

// ВАРИАНТ РЕШЕНИЯ 2:
// int Prompt(string message)
// {
//     Console.Write(message);
//     string strValue = Console.ReadLine() ?? "0";
//     int value = int.Parse(strValue);
//     return value;
// }
// int temp1 = Prompt("Введите пятизначное число: ");
// if (temp1 < 10000 || temp1 > 99999)
// {
//     Console.WriteLine("Вы ввели некорректное число");
// }
// string str = temp1.ToString();
// int[] palindrom = new int[str.Length];
// for (int i = 0; i < str.Length; i++)
// {
//     palindrom[i] = int.Parse(str[i].ToString());
// }
// var reverse = new[] { str.Length };
// Array.Reverse(palindrom);
// Console.WriteLine(string.Join(" ", palindrom));

// void Main()
// {
//     string palindrom;

//     palindrom = Console.ReadLine();
//     string[] temp2 = palindrom.Split(' ');

//     //Преобразование Массива типа String[] в тип Int[] -C#
//     int[] temp3 = Array.ConvertAll(temp2, int.Parse);
  
//     Console.WriteLine(temp3);
// }
// Main();
// // if (temp3 == temp2)
// // {
// //     Console.WriteLine("Да");
// // }
// // else
// // {
// //     Console.WriteLine("Нет");
// // }


