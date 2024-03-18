// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = -number;
// while (i <= number)
// {
//     Console.Write($"{i} ");
//     i++;
// }


// Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.

// Console.WriteLine(" введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n / 100;
// int b = n % 10; 
// int sum = (a + b); // / 10;

// if (n < 100 || n > 1000)
// {
//     Console.WriteLine("это не трехзначное число...");
// }
// else 
// {
//     Console.WriteLine($" сумма первого и третьего числа {n} равна {sum} ");
// }

//Второе решение

Console.WriteLine(" введите трехзначное число: ");
string n = Console.ReadLine()!;

if (n.Length != 3)
{
    Console.Write("это не трехзначное число...");
}
else 
{
    Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0])) 
                                         + Convert.ToInt32(Convert.ToString(n[2])));
}