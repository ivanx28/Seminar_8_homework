// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Вариант математического переумножения матриц.


int[,] FillArray(int x, int y)
{
    int[,] arbitraryArray = new int[x, y];
    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            arbitraryArray[i,j] = new Random().Next(1, 11);
        }
    }
    return arbitraryArray;
}

void PrintArray (int[,] arbitraryArray)
{
    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            Console.Write($"| {arbitraryArray[i,j]} |");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplication (int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0);i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraySecond.GetLength(0); k++)
            {
                resultArray[i,j] += arrayFirst[i,k] * arraySecond[k, j];
            }
        }
    }
    return resultArray;
}

Console.WriteLine("Введите количество строк первой матрицы");
int linesFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columnFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int linesSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columnSecond = Convert.ToInt32(Console.ReadLine());

if (columnFirst != linesSecond)
{
    Console.WriteLine("Перемножение невозможно, так как количество столбцов первой матрицы неравно количество строк второй матрицы");
    return;
}

int[,] firstArray = FillArray(linesFirst, columnFirst);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = FillArray(linesSecond, columnSecond);
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Матрица получившаяся после переумножения первой и второй матрицы:");
PrintArray(MatrixMultiplication(firstArray, secondArray));