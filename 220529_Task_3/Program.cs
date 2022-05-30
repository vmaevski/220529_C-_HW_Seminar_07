// 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void PrintColumnAverage(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int sum = 0;
    Console.WriteLine("Average:");
    for (int j = 0; j < column; j++)
    {
        sum = 0;
        for (int i = 0; i < row; i++)
        {
            sum += array[i, j];
        } 
        Console.Write($"{Math.Round((double)sum / row, 1)}" + "\t");
    }
    Console.WriteLine();
}

int[,] Random2DArray(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон значений от: ");
int from = int.Parse(Console.ReadLine());
Console.Write("Введите диапазон значений до: ");
int to = int.Parse(Console.ReadLine());
int[,] array = Random2DArray(row, column, from, to);
Print2DArray(array);
PrintColumnAverage(array);