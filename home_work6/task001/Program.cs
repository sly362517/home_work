Console.Clear();
Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result++;
    }
}
 
Console.WriteLine($"Количество элементов больше 0: {result}");