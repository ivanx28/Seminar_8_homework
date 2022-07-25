//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindMinLine(int[,] arbitraryArray)
{
    int sum = int.MaxValue;
    int indexMinLine = 0;
    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            sumLine += arbitraryArray[i,j];
        }
        if (sumLine < sum)
        {
            sum = sumLine;
            indexMinLine = i;
        }
    }
    Console.WriteLine($"Минимальная строка находится под номером {indexMinLine + 1} и сумма её элементов равняется {sum}");
}


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
FindMinLine(array);