Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 99)
    {
        while(n > 1000)
        n = n / 10;
    Console.Write(n % 10);
    }
else
    Console.Write("Третьей цифры нет");