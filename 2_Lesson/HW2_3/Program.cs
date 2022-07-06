//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdNum(int num)
{
    Console.Write($"{num} ->");
    if (num <100)
    {
        Console.WriteLine("there is not third number");
        return;
    }
    while (num > 1000) num = num / 10;
    Console.WriteLine(num % 10);
}
ThirdNum(int.Parse(Console.ReadLine()));
