// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Summary(int num)
{
    int result = 0;

    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
Console.WriteLine(Summary(452));
Console.WriteLine(Summary(82));
Console.WriteLine(Summary(9012));