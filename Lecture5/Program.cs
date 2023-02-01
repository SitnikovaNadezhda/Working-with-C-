// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void SwiftRowsColumnArray(int[,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Ошибка!");
//     }
//     else
//     {
//         int buf = 0;

//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i; j < array.GetLength(1); j++)
//             {
//                 buf = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = buf;
//             }
//         }
//     }
// }

// int[,] SwapArray(int[,] array)
// {
//     int[,] ArrayNew = new int[array.GetLength(0), array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             ArrayNew[j, i] = array[i,j];
//         }
//     }
//     Console.WriteLine();
//     return ArrayNew;
// }







//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SwapArray(int[,] array)
// {
//     int buf = 0;
//     int lastRow = array.GetLength(0) - 1;
//     for (int column = 0; column < array.GetLength(1); column++)
//     {
//         buf = array[0, column];
//         array[0, column] = array[lastRow, column];
//         array[lastRow, column] = buf;
//     }
// }

// Console.WriteLine("Enter number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter numbe

