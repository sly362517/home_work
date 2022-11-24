Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(n == m && n == b) 
    Console.Write("Числа равны");
else if(n > m && n > b) 
    Console.Write(n);
else if(m > n && m > b) 
    Console.Write(m);
else 
    Console.Write(b);