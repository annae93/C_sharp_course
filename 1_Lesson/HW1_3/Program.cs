//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без оcтатка).
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($" number {a} is integer");
}
else
{
    Console.WriteLine($" number {a} is non-integer");
}