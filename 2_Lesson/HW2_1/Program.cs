//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int ThreePartNum(int num)
{
    return num /  10 % 10;
}

Console.WriteLine(ThreePartNum(918));