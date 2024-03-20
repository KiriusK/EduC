// Task 1
// int num=new Random().Next(100,1000);
// Console.WriteLine(num);
// int first=num/100;
// int last=num%10;
// Console.WriteLine(first+""+last);
// Console.WriteLine(first*10+last);
// int res=first*10+last;
// Console.WriteLine($"{num}->{res}");
// string num_str=Convert.ToString(num);
// Console.WriteLine(num_str[0]+""+num_str[2]);
// Console.WriteLine(Convert.ToString(num_str[0])+Convert.ToString(num_str[2]));

// // Task 2
// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);
// int sec = num / 10 % 10;
// int last = num % 10;
// Console.WriteLine(sec);
// Console.WriteLine(last);
// double res = Math.Pow(sec, last);
// // Second variant, не работает с 0!
// Console.WriteLine(res);
// int i=1;
// int c=sec;
// Console.WriteLine();
// while (i<last) {
//     c*=sec;
//     Console.WriteLine(c);
//     i++;
// }
// int i1=0;
// int c1=1;
// Console.WriteLine();
// while (i1<last) {
//     c1*=sec;
//     Console.WriteLine(c1);
//     i1++;
// }

// Task 3

// int first,sec;
// do
// {
//     first = 11;
//     sec=0;  
// } while (first<sec);
// if (sec==0) Console.WriteLine("Деление на 0");
// else {
// int res=first%sec;
// if (res==0) Console.WriteLine("Да");
// else Console.WriteLine($"Нет, {res}");
// }

// Task 4

int num = new Random().Next(1, 1000000);
Console.WriteLine(num);
int res = 0;
if (num < 100) Console.WriteLine("Нет третьего числа");
else
{
    while (num >= 100)
    {
        res = num % 10;
        num /= 10;
    }
    Console.WriteLine(res);
}