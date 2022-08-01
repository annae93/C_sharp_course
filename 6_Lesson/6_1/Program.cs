﻿// 1. Напишите программу, которая принимает на вход три числа
//    и проверяет, может ли существовать треугольник с сторонами такой длины.


void ExiTri(int n_1, int n_2, int n_3)
{
    if (n_1 < n_2 + n_3 && n_2 < n_1 + n_3 && n_3 < n_2 + n_1)
    {
        Console.WriteLine("The triangle exists.");
    }
    else
    {
        Console.WriteLine("The triangle does not exist.");
    }
}

ExiTri(1, 2, 3);
ExiTri(4, 2, 5);