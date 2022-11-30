Console.Clear();
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;
if(length == 5)
{
    if (number [0] == number [4] && number[1] == number[3])
        Console.WriteLine("Палиндром");
    else
        Console.WriteLine("Не палиндром");
}
else
    Console.WriteLine("Вы ошиблись!");
