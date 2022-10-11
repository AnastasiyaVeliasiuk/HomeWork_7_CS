// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


/*void FillArray(double [,] matrix)                      // метод, который заполняет двухмерную таблицу на экран
{                                                       // и заполнять его случайными вещественными числами
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = new Random().NextDouble();
        }
    }
}
void PrintArray(double [,] matrix)                     // метод, который печатает двухмерную таблицу на экран
{                                                       // и заполнять его случайными вещественными числами
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 1)}  ");
        }
    Console.WriteLine();
    }
}
      
int m = new Random().Next(2,6);             // количество строк массива
int n = new Random().Next(2,6);             // количество столбцов массива
double [,] table = new double [m, n];
FillArray(table);
PrintArray(table);*/


// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*void FillandPrintArray(int [,] matrix1)               // метод, который заполняет двухмерную таблицу на экран
{                                                       // и заполнять его случайными вещественными числами
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1 [i, j] = new Random().Next(5,10);
            Console.Write($"{matrix1[i, j]}  ");
        }
        Console.WriteLine();   
    }   
}
int [,] matrix = new int [5, 10];
FillandPrintArray(matrix);
Console.Write($"Введите позицию строки от 1 до 5: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите позицию столбика от 1 до 10: ");
int b = Convert.ToInt32(Console.ReadLine());
int indexString = a - 1;
int indexColumn = b - 1;

if ( indexString < matrix.GetLength(0) && indexColumn < matrix.GetLength(1))
{
    Console.Write( matrix [indexString, indexColumn]);
}
else
{
    Console.Write("Такого числа нет в таблице");
}
Console.WriteLine(); */



// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*void FillandPrintArray(int [,] matrix1)               // метод, который заполняет двухмерную таблицу на экран
{                                                       // и заполнять его случайными вещественными числами
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1 [i, j] = new Random().Next(5,10);
            Console.Write($"{matrix1[i, j]}  ");
        }
        Console.WriteLine();   
    }   
}

int [,] matrix = new int [5,10];
FillandPrintArray(matrix);

{                                                       // и заполнять его случайными вещественными числами
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum = sum + matrix[i, j];
        }
    Console.Write($"{sum / (matrix.GetLength(0))};  ");
    }
}*/