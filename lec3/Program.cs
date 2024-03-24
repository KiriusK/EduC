// // Task 1
// double Calculate(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     double denumenator = c + d;
//     double result = numenator / denumenator;
//     return result;
// }
// double result = Calculate(2, 3, 4, 5);
// Console.WriteLine(result);

// // Task 2 
// void PrintSquares (int limit) {
//     int i=1;
//     while (i<=limit) {
//         Console.Write($"{i*i} ");
//         i++;
//     }
//     Console.WriteLine();
// }
// PrintSquares(5);
// PrintSquares(10);
// PrintSquares(15);

// // Task 3
// void ZeroEven(int[] arr) {
//     for(int i=0;i<arr.Length;i++) {
//         if (arr[i]%2==0) arr[i]=0;
//     }
// }
// void PrintArr(int[] arr) {
//     foreach (int e in arr) {
//         Console.Write($"{e} ");
//     }
//     Console.WriteLine();
// }
// int[] arr={1,2,6,6,7,8,89,9,90,3,4,5};
// PrintArr(arr);
// ZeroEven(arr);
// PrintArr(arr);

// Task 4
void PrintArr(int[] array) {
    foreach (int e in array) {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}

void FillArr(int[] array) {
    Random rnd= new Random();
    for (int i=0;i<array.Length;i++) {
        array[i]=rnd.Next(1,11);
    }
}

int GetSum(int[] array) {
    int sum=0;
    foreach (int e in array) {
        sum+=e;
    }
    return sum;
}

int GetProduct (int[] array) {
    int product=1;
    foreach (int e in array) {
        product*=e;
    }
    return product;
}

Console.Write("Введите размер массива: ");
string input=Console.ReadLine()!;
int len=Convert.ToInt32(input);
int[] arr=new int[len];
FillArr(arr);
PrintArr(arr);
int sum=GetSum(arr);
int product=GetProduct(arr);
Console.WriteLine($"Сумма элементов равна {sum}");
Console.WriteLine($"Произведение элементов равно {product}");