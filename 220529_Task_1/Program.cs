// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] Random2DArray(int row, int column, double from, double to)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().NextDouble() * (to - from) + from;
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)}" + "\t");
        }
    Console.WriteLine();    
    }
}

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine());
Print2DArray(Random2DArray(row, column, -50, 50));