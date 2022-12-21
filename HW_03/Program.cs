// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2  0/0 0/1 0/2 0/4
// 5 9 2 3  1/0 1/1 1/2 1/4
// 8 4 2 4  2/0 2/1 2/3 2/4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AverageInColumnArray(int[,] arr, int rows, int columns)
{
    double sum = 0;
    double awerage = 0;
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
           sum += arr[i, j];
           awerage = sum / rows;
        }
        Console.Write("{0:F1}; ", awerage);
        sum = 0;
        awerage = 0;
    }
}

void PrintArray(int[,] arr, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(begin, end);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");

int[,] matrix = FillArray(rows, columns, 0, 10);

PrintArray(matrix, rows, columns);
AverageInColumnArray(matrix, rows, columns);