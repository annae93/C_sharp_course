//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 < num2)
{
     num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}
Console.Write($"The number {num1} is largest");
