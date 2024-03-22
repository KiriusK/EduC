// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
//одновременно 7 и 23.
Console.WriteLine("Задача 1, Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num%7==0&&num%23==0) Console.WriteLine($"Число {num} кратно 7 и 23");
else Console.WriteLine($"Число {num} некратно 7 или 23");

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.WriteLine("Задача 2"); 
Console.WriteLine("Введите координату X, не равную 0:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y, не равную 0:");
int y = Convert.ToInt32(Console.ReadLine());
if (x==0||y==0) Console.WriteLine("Неверные координаты, введите отличные от 0 координаты!");
else {
    if (x>0&&y>0) Console.WriteLine("I четверть");
    if (x<0&&y>0) Console.WriteLine("II четверть");
    if (x<0&&y<0) Console.WriteLine("III четверть");
    if (x>0&&y<0) Console.WriteLine("IV четверть");
}

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
Console.WriteLine("Задача 3, Введите число в диапазоне от 10 до 99:");
num = Convert.ToInt32(Console.ReadLine());
if (num>10&&num<99) {
    int first=num/10;
    int sec=num%10;
    if (first>sec) Console.WriteLine($"Наибольшее число {first}");
    else Console.WriteLine($"Наибольшее число {sec}");
}
else Console.WriteLine("Число должно быть двухзначным!");

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.
Console.WriteLine("Задача 4, Введите натуральное число:");
num = Convert.ToInt32(Console.ReadLine());
int d=1000000000;
while (d >= 10)
{
    if (num>d) {
    Console.Write($"{num / d}, ");
    num%=d;
    }
    d /= 10;    
}
Console.Write(num / d);
Console.WriteLine();