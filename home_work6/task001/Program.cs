Console.Clear();
string[] n = Console.ReadLine().Split(" ");
int result = 0;
foreach (string i in n)
{
    if (int.Parse(i) > 0)
    result++;
}
Console.WriteLine($"Количество чисел больше 0: {result}");