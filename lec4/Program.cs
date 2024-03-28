// // Task 1

// int[,] CreateMatrix(int rowCount,int columnCount) {
//     int [,] matrix=new int[rowCount,columnCount];
//     Random rnd=new Random();
//     for (int i=0;i<matrix.GetLength(0);i++) {
//         for (int j=0;j<matrix.GetLength(1);j++) {
//             matrix[i,j]=rnd.Next(1,11);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix) {
//     for (int i=0;i<matrix.GetLength(0);i++) {
//         for (int j=0;j<matrix.GetLength(1);j++) {
//             Console.Write($"{matrix[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] matrix=CreateMatrix(5,8);
// PrintMatrix(matrix);

// // Виды инициализации многомерных массивов
// int[,] mtr1=new int[2,4] {{1,1,1,1},{2,2,2,2}};
// int[,] mtr2=new int[,] {{3,3,3,3,3},{4,4,4,4,4}};
// int[,] mtr3={{5,5,5,5,5,5},{6,6,6,6,6,6}};
// PrintMatrix(mtr1);
// PrintMatrix(mtr2);
// PrintMatrix(mtr3);

// // Task 2 

// int[,] CreateMatrix(int rowCount,int columnCount) {
//     int [,] matrix=new int[rowCount,columnCount];
//     Random rnd=new Random();
//     for (int i=0;i<matrix.GetLength(0);i++) {
//         for (int j=0;j<matrix.GetLength(1);j++) {
//             matrix[i,j]=rnd.Next(1,1000);
//         }
//     }
//     return matrix;
// }

// bool IsInteresting(int value) {
//     int sum=GetSum(value);
//     if (sum%2==0) return true;
//     return false;
// }

// int GetSum(int value) {
//     int sum=0;
//     while(value>0) {
//         sum+=value%10;
//         value/=10;
//     }
//     return sum;
// }

// int[,] arr=CreateMatrix(3,4);
// PrintMatrix(arr);
// foreach (int e in arr) {
//     if (IsInteresting(e)) Console.Write($"{e} ");
// }

// Task 3

// string GetLetters(string s) {
//     string letters="";
//     foreach (char e in s) {
//         if (char.IsAsciiLetter(e)) letters+=e;
//     }
//     return letters;
// }

// Console.Write("Input some symbols: ");
// string? str=Console.ReadLine();
// string result=GetLetters(str);
// Console.WriteLine(result);

// Task 4

string GetDigits(string s) {
    string digits="";
    foreach (char e in s) {
        if (char.IsDigit(e)) digits+=e;
    }
    return digits;
}

int[] StringToArr(string s) {
    int[] arr=new int [s.Length];
    for (int i=0; i<s.Length;i++) {
        arr[i]=int.Parse(Convert.ToString(s[i]));
    }
    return arr;
}

void PrintArr(int[] arr) {
    Console.WriteLine("Result array: ");
    foreach (int e in arr) {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}

Console.Write("Input some symbols: ");
string? str=Console.ReadLine()!;
string digits=GetDigits(str)!;
Console.WriteLine(digits);
int[] arr=StringToArr(digits);
PrintArr(arr);