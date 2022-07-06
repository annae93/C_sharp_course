void OneAndTwo(int num)
{       
    if (num % 7 == 0 & num % 23 == 0)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else
    {
        Console.WriteLine($"{num} -> no");        
    }    
}

OneAndTwo(14);
OneAndTwo(46);
OneAndTwo(161);

