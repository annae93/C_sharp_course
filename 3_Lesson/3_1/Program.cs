// 1. Напишите программу, которая принимает на вход координаты точки (X и Y),
//    причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quaters(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("x = 0, y = 0");
    }
    else if (x > 0 & y > 0)
    {
        Console.WriteLine("I");
    }
    else if (x < 0 & y > 0)
    {
        Console.WriteLine("II");
    }
    else if (x < 0 & y < 0)
    {
        Console.WriteLine("III");
    }
    else if (x > 0 & y < 0)
    {
        Console.WriteLine("IV");
    }
}

Quaters(2, 2);
Quaters(-2, 2);
Quaters(-2, -2);
Quaters(2, -2);
Quaters(0, -2);
Quaters(2, 0);

// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).

//void Coordinates(string num)
//{
    //if (num == "I")
    //{
    //    Console.WriteLine("x > 0, y > 0");
    //}
    //else if (num == "II")
    //{
      //  Console.WriteLine("x < 0, y > 0");
    //}
    //else if (num == "III")
    //{
    //    Console.WriteLine("x < 0, y < 0");
    //}
    //else if (num == "IV")
    //{
      //  Console.WriteLine("x > 0, y < 0");
    //}
    //else
    //{
    //    Console.WriteLine("The data is not correct!");
    //}
//}

//Coordinates("I");
//Coordinates("IV");
//Coordinates("II");
//Coordinates("III");
//Coordinates("X");