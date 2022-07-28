// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int PowNum(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
Console.WriteLine("Enter first number:");
int n_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int n_2 = int.Parse(Console.ReadLine());
Console.WriteLine(PowNum(n_1,n_2));
