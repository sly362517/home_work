void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101);
}


void ReleaseArray(int[] array)
{
    int result = 0;
    for( int i = 1; i < array.Length; i = i + 2)
        result += array[i];
    Console.WriteLine($"Сумма элементов на нечётных местах: {result}");
}


Console.Clear();
Console.Write("Введите количество элемнтов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
