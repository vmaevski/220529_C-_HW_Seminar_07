// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

double GetElementValue(double[,] array, int row, int column)
{
    double num;
    num = array[row, column];
    return num;
}

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
double[,] array = Random2DArray(row, column, -50, 50);
Print2DArray(array);
Console.Write("Введите номер строки элемента: ");
int rowNumber = int.Parse(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца элемента: ");
int columnNumber = int.Parse(Console.ReadLine()) - 1;
// if (rowNumber > array.GetLength(0) || columnNumber > array.GetLength(1) || rowNumber < 1 || columnNumber < 1)
if (rowNumber > row || columnNumber > column || rowNumber < 1 || columnNumber < 1)
{
    Console.WriteLine("Такого элемента нет!");
}
else
{
    Console.WriteLine(Math.Round(GetElementValue(array, rowNumber, columnNumber), 2));
}


