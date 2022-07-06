//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"The first number {num1} is greater than second number {num2}");
}
else
{
    Console.WriteLine($"The second number {num2} is greater than first number {num1}");
}

