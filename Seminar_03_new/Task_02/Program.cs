int quarterNumber = Convert.ToInt32(Console.ReadLine());

if (quarterNumber == 1) Console.WriteLine("x > 0 && y > 0");

else if (quarterNumber == 2) Console.WriteLine("x < 0 && y > 0");

else if (quarterNumber == 3) Console.WriteLine("x < 0 && y < 0");

else if (quarterNumber == 3) Console.WriteLine("x > 0 && y < 0");

else Console.WriteLine("Ошибка в введении четверти");