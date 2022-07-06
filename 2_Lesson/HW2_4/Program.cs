//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write ("Enter week day: ");
string DayOfWeek = Console.ReadLine();
int dayNum = int.Parse(DayOfWeek);
if (dayNum == 6)
{
    Console.WriteLine("yes");
}
else if (dayNum == 7)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


