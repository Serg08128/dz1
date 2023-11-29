// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0: {count}");



// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите значения k1, b1, k2 и b2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");

//         // Ввод коэффициентов для первой прямой
//         Console.Write("k1: ");
//         double k1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("b1: ");
//         double b1 = Convert.ToDouble(Console.ReadLine());

//         // Ввод коэффициентов для второй прямой
//         Console.Write("k2: ");
//         double k2 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("b2: ");
//         double b2 = Convert.ToDouble(Console.ReadLine());

//         // Вычисление точки пересечения
//         double xIntersection = (b2 - b1) / (k1 - k2);
//         double yIntersection = k1 * xIntersection + b1;

//         // Вывод результатов
//         Console.WriteLine($"Точка пересечения: ({xIntersection}, {yIntersection})");
//     }
// }

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         PrintNumbers(N);

//         Console.ReadKey();
//     }
//   }
//   

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summa(int m, int n)
// {
// if (m==n)
// return n;
// else return m + summa(m + 1, n);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write($"A(m,n)= {akkerman(m, n)} ");