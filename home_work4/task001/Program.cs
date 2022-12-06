Console.Clear();
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;

for (int i = 1; i < b; i++)
{
stepen = stepen * a;
}
Console.WriteLine("Число A в степени B равно: " + stepen);