// 3. Напишите программу, которая задаёт массив из 8 элементов
//    случайными числами и выводит их на экран. Оформите заполнение массива
//    и вывод в виде функции (пригодится в следующих задачах)
void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] EightMass()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 1000);       
    }    
    return arr;
}

int[] arr_1 = EightMass();
PrintArray(arr_1);
int[] arr_2 = EightMass();
PrintArray(arr_2);