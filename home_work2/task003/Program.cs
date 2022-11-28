Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 6 || n == 7)
    Console.Write("Выходной день");
else
    Console.Write("Будний день");