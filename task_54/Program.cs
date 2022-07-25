// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SortArray(int[,] arbitraryArray)
{

    for(int i = 0; i < arbitraryArray.GetLength(0); i++)
    {
        for (int j = 0; j < arbitraryArray.GetLength(1); j++)
        {
            for (int k = j+1; k < arbitraryArray.GetLength(1); k++)
            {
                if (arbitraryArray[i,j] > arbitraryArray[i,k])      // Если нужно отсортировать от большего к меньшему, то просто меняем знак на "меньше".
                {
                    int temporary = arbitraryArray[i,j];
                    arbitraryArray[i,j] = arbitraryArray[i,k];
                    arbitraryArray[i,k] = temporary;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);
