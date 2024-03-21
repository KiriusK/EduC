// // Training
// Console.WriteLine("ВВедите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int i = 0;
// // while
// while (i < arr.Length)
// {
//     Console.Write($"{arr[i]}, ");
//     i++;
// }
// Console.WriteLine();
// // for
// for (int j = 0; j < arr.Length; j++)
// {
//     Console.Write($"{arr[j]}, ");
// }
// Console.WriteLine();
// //foreach
// foreach (int k in arr)
// {
//     Console.Write($"{k}, ");
// }
// Console.WriteLine();
// function
void PrintMas(int[] coll)
{
    foreach (int i in coll)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("Array end");
}
//PrintMas(arr);
// Task 1
// int[] RandArr(int[] arr) {
//     for (int i = 0; i < arr.Length; i++)
// {
//     arr[i]= new Random().Next(-10,11);
// }
// return arr;
// }
// string S(int[] col, int m)
// {
//     foreach (var item in col)
//     {
//         if(item == m) return "Да";
//     }
//     return "Нет";
// }

// Console.WriteLine("ВВедите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите число");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int[] newArr=RandArr(arr);
// PrintMas(newArr);
// int flag=0;
// foreach (int i in newArr)
// {
//     if (i==m) flag++;
// }
// if (flag>0) {
//     Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");
// Console.WriteLine(S(newArr, m));
// Task 2
// int[] RevMas(int[] coll){
//     for (int i = 0; i < coll.Length; i++)
// {
//     //coll[i]=coll[i]*-1;
//     coll[i]*=-1;
// }
// return coll;
// }

// Console.WriteLine("ВВедите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int[] newArr=RandArr(arr);
// PrintMas(arr);
// int[] revArr=RevMas(newArr);
// PrintMas(revArr);
// Task 3, не мой
// int[] Append(int len)
// {
//     int[] list = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         list[i] = new Random().Next(1, 21);
//     }
//     foreach (int i in list)
//     {
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();
//     return list;
// }

// int len = 9;

// int[] lst = Append(len);

// int l = lst.Length;

// int index = 0;


// while (index < lst.Length / 2)
// {
//     Console.Write(lst[index] * lst[lst.Length - index - 1] + " ");

//     index++;
// }

// Task 4
Console.WriteLine("ВВедите число");
string num = Console.ReadLine()!;//! - убирает предупреждения
int len = num.Length;
int m = Convert.ToInt32(num)!;
int n = Convert.ToInt32(num)!;
int[] arr = new int[len];
int i = 0;
while (m >= 1)
{
    arr[i] = m % 10;
    m /= 10;
    i++;

}
PrintMas(arr);

i = 0;
int[] arr2 = new int[len];
int d = Convert.ToInt32(Math.Pow(10, len - 1));
while (d >= 1)
{
    arr2[i] = n / d;
    n%=d;
    d /= 10;
    i++;
}
PrintMas(arr2);


// Решение через строки

// Convert.ToInt32(Console.ReadLine());

// string n = Console.ReadLine();
// int len = n.Length;

// int[] arr = new int[len];
//  for ( int i = 0; i < len; i++)
//  {
//     arr[i] = Convert.ToInt32(Convert.ToString(n[i])); 
//  }

// void PrintMas(int[] col)
// {
//     foreach (int item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// PrintMas(arr);

// int[] arr2 = new int[len];

// for ( int i = 0; i < len; i++)
//  {
//     arr2[i] = Convert.ToInt32(Convert.ToString(n[len - 1 - i])); 
//  }

//  PrintMas(arr2);