// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = GetAndPrintValue("Введите количество строк: ");
int n = GetAndPrintValue("Введите количество столбцов: ");

int GetAndPrintValue(string msg)
{
    Console.Write(msg);
    string input = Console.ReadLine();
    int value = Convert.ToInt32(input);
    return value;
}

double[,] FillArray(int m, int n)
{
    Random rnd = new Random();
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);

        }
    }
    return matrix;
}
double[,] array = FillArray(m, n);

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:F1}", ($"{array[i, j]}\t")));
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine();