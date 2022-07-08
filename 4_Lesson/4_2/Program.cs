// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.


// 2 вариант

int NumCount(int num)
{
    int result = 0;

    while (num > 0)
    {
        num /= 10;
        result += 1;
    }
    return result;
}

Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));