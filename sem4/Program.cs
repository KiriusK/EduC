// Task 1. Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.
// Пример препода.

int[] RandomMass(int m)
{
    int[] Number = new int[m];
    for (int i = 0; i < Number.Length; i++)
    {
        Number[i] = new Random().Next(0,10);
    }
    return Number;
}

void PrintMass(int[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

// bool prost(int num)
// {
//     for (int i = 2; i < num; i++)
//     {
//         if(num % i == 0) return false;
//     }
//     Console.WriteLine(num);
//     return true;
// }


// int Count(int[] col)
// {
//     int count = 0;
//     foreach (var i in col)
//     {
//         if(prost(i)) count++;
//     }
//     return count;
// }


// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] mas = RandomMass(n);
// PrintMass(mas);
// Console.WriteLine($"Количество простых чисел в массиве равно {Count(mas)}");

// Task 2.Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

// int CountSeven(int[] col) {
//     int count=0;
//     foreach (int e in col){
//         if (e>10) {
//             if (e%10==1&&e%7==0) {
//                 count++;
//                 Console.Write($"{e} ");
//             }  
//         }
//     }
//     Console.WriteLine();
//     return count;

// }

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr=RandomMass(n);
// PrintMass(arr);
// Console.WriteLine($"Количество чисел, которые оканчиваются на 1 и делятся нацело на 7: {CountSeven(arr)}");

// Task 3. Заполните массив на  N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9. 
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.

int ArrToNumber(int[] coll) {
    int num=0;
    int razr=1;
    for (int i=coll.Length-1;i>=0;i--) {
        num+=coll[i]*razr; 
        razr*=10;
    }
    // Можно так)
    //  for (int i = 0; i < coll.Length; i++)
    // {
    //     num = num * 10  + coll[i];       
    // }
    return num;
}
// Можно так)
int NumWriter(int[] list)
{
    int res = 0;
    foreach(int num in list)
    {
        res *= 10;
        res += num;
    }

    return res;
}


Console.Write("Введите размерность массива, не более 8: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n<9) {
int[] arr=RandomMass(n);
PrintMass(arr);
Console.WriteLine($"Число из массива: {ArrToNumber(arr)}");
}
else Console.WriteLine("Число не больше 8!");

// // Решение с урока
// //используем заготовку
// using System.Security.Cryptography;

// int[] RandomMass(int m)
// {
//     int[] Number = new int[m];
//     for (int i = 0; i < Number.Length; i++)
//     {
//         Number[i] = new Random().Next(0,9);
//         Console.Write($"{Number[i]}, ");
//     }
//     return Number;
// }

// //функцию для подбора
// string FindFirstAndLast(int[] col)
// {
//     string number = "";
//     for (int i = 0; i < col.Length; i++)
//     {
//         number = number + Convert.ToString(col[i]);
        
//     }
//     return number;
// }

// //это для ввода размерности
// Console.Write("Введите размерность массива не более 8: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomMass(n);
// string str = FindFirstAndLast(arr);
// Console.WriteLine();
// Console.WriteLine(str);