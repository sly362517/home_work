﻿Console.Clear();
int[] array = new int[8];
for (int i = 0; i < 8; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: [{string.Join(", ", array)}]"); 