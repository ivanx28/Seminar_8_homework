// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Вариант как указан в примере (поэлементное умножение).


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

int[,] ArrayMultiplication (int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int[arrayFirst.GetLength(0), arrayFirst.GetLength(1)];
    for(int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            resultArray[i,j] = arrayFirst[i,j] * arraySecond[i,j];
        }
    }
    return resultArray;
}

Console.WriteLine("Введите количество строк первого массива: ");
int linesFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первого массива: ");
int columnFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второго массива: ");
int linesSecond = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второго массива: ");
int columnSecond = Convert.ToInt32(Console.ReadLine());

if (linesFirst != linesSecond && columnFirst != columnSecond)
{
    Console.WriteLine("Перемножение невозможно, так как количество строк и столбцов не равно");
    return;
}

int[,] firstArray = FillArray(linesFirst, columnFirst);
PrintArray(firstArray);
Console.WriteLine();
int[,] secondArray = FillArray(linesSecond, columnSecond);
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Массив получившийся после переумножения первого и второго массива:");
PrintArray(ArrayMultiplication(firstArray, secondArray));
