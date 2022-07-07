//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Write("Enter your number: ");
string num = Console.ReadLine();

void CheckNum(string num)
{
  if (num[0] == num[4] || num[1]==num[3])
  {
    Console.WriteLine($"Your number: {num} - is Palindrome.");
  }
  else Console.WriteLine($"Your number: {num} - is non-Palindrome.");
}

if (num.Length == 5)
{
  CheckNum(num);
}
else Console.WriteLine($"Type correct number");