﻿void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}


void ReleaseArray(int[] array)
{
    int result = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        result ++;
    }
    Console.WriteLine($"Количество чётных чисел: {result}");
}


Console.Clear();
Console.Write("Введите количество элемнтов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);