int MaxNumber(int a)
{
    Console.WriteLine(a);
    
    if (a % 10 > a / 10)
    {
        return a % 10;
    }
    else
    {
        return a / 10;
    }
}


Console.WriteLine(MaxNumber(new Random().Next(10, 100)));
