﻿/*
Задача 43: 
Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)
*/

Console.WriteLine("Есть 2 прямые: y = k1 * x + b1   и   y = k2 * x + b2  ");
Console.WriteLine("От вас требуется задать значения b1; k1 и b2; k2 , что-бы найти точку пересечения двух прямых");
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void FindPoit()
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны  ");
    }
    else
    {
        double Xcord = ((b1 - b2) * -1) / (k1 - k2);
        double Ycord = k1 * Xcord + b1;
        Console.WriteLine("Координаты пересечения прямых: ");
        Console.WriteLine("X = " + Xcord);
        Console.WriteLine("Y = " + Ycord);
    }
}

FindPoit();