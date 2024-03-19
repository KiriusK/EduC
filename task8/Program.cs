// Task 1
// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 6;
// arr[2] = 7;
// arr[3] = 1;
// arr[4] = 2;
// Console.Write($"{arr[0]} ");
// Console.Write($"{arr[1]} ");
// Console.Write($"{arr[2]} ");
// Console.Write($"{arr[3]} ");
// Console.Write($"{arr[4]} ");
// //Console.Write($"{arr[5]} ");
// Console.WriteLine(" ");
// int[] arr1 = new int[5] { 3, 4, 5, 2, 1 };
// int[] arr2 = { 1, 2, 5, 7, 3, 6, 8 };

// Task 2
// int n=10;
// int[] arr= new int[n];
// int i=0;
// while (i<arr.Length) {
//     arr[i]=i+1;
//     Console.Write($"{arr[i]} ");
//     i++;
// }

// Task 3
// int [] arr={673,3543,33,345,465,373,43,45,7653,373};
// int i=0;
// while (i<arr.Length) {
//     if (arr[i]%2==0) Console.Write($"{arr[i]} ");
//     i++;
// }

// Task4
int [] arr={673,3543,33,345,465,373,43,45,7653,373};
int i=0;
int max=arr[0];
while (i<arr.Length) {
    if (arr[i]>max) max=arr[i];
    i++;
}
Console.WriteLine($"{max} ");

// Cycles
max = arr[0];
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max) max = arr[j];
}
Console.WriteLine($"{max} ");

max = arr[0];
foreach (int e in arr) {
    if (e > max) max = e;
}
Console.WriteLine($"{max} ");