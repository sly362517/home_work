﻿Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0)
    Console.Write("Чётное число");
else 
    Console.Write("Нечётное число");