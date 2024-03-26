// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

string ReadNumber() {
    Console.WriteLine("Введите целое число  или q для выхода");
    string? input=Console.ReadLine()!;
    return input;
}

bool InputCheck(string input) {
    if (input=="q"||input=="Q") return false;
    int num=Convert.ToInt32(input);
    if (num<10) return true;
    int sum=0;
    while (num>0) {
        sum+=num%10;
        num/=10;
    }
    if (sum%2==0) return false;
    else return true;
}
 
bool cond = true;
while (cond) {
    string input=ReadNumber();
    cond=InputCheck(input);
}
Console.WriteLine("Конец первой задачи!");

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreatArr100_1000() {
    Console.WriteLine("Введите размер массива");
    int len=Convert.ToInt32(Console.ReadLine())!;
    int[] arr=new int[len];
    Random rnd=new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i]=rnd.Next(100,1000);
    }
    return arr;
}

void PrintArr(int[] arr) {
    foreach (int e in arr) {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}

void CountEven(int[] arr) {
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
    }
    Console.WriteLine($"Количество четных чисел равно {count}");
}

int[] arr=CreatArr100_1000();
PrintArr(arr);
CountEven(arr);

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreatArr1_100() {
    Console.WriteLine("Введите размер массива");
    int len=Convert.ToInt32(Console.ReadLine())!;
    int[] arr=new int[len];
    Random rnd=new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i]=rnd.Next(1,100);
    }
    return arr;
}

void ReverseArr(int[] arr) {
    int tmp=0;
    int len=arr.Length;
    for (int i=0;i<len/2;i++) {
        tmp=arr[i];
        arr[i]=arr[len-1-i];
        arr[len-1-i]=tmp;
    }
}
 arr=CreatArr1_100();
 PrintArr(arr);
 ReverseArr(arr);
 PrintArr(arr);