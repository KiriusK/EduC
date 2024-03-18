// // Задача 1
// using System;

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже
//         if (firstNumber>secondNumber) Console.WriteLine("первое число больше");
//         if (secondNumber>firstNumber) Console.WriteLine("второе число больше");
//         if (firstNumber==secondNumber) Console.WriteLine("числа равны");


//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 5;
//             secondNumber = 9;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// Задача 2
// using System;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
//       int max=a;
//       if (b>max) max=b;
//       if (c>max) max=c;
//       return max;


//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 7;
//            b = 7;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// Задача 3
// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//       if (number%2==0) Console.WriteLine("четное");
//       else Console.WriteLine("нечетное");

//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 222223;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

// Задача 4
using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      int i=1;
      while (i<=number) {
        if (i%2==0) Console.Write("{0} ",i);
        i++;
      }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 455;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}