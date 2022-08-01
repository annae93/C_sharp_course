int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int count = n / 2;
PrintNumber(n, count);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 2);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
