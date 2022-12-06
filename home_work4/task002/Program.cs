Console.Clear();
Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int summa = 0;
while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    summa = summa + number;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + summa);