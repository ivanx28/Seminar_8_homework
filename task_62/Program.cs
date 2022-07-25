// Заполните спирально массив 4 на 4.

int[,] SpiralArray(int[,] arbitraryArray, int number)           // Метод спирального заполнения массива.
{
    int i = 0;
    int j = 0;

    while (number <= arbitraryArray.Length)
    {
        arbitraryArray[i, j] = number;
            if (i <= j + 1 && i + j < arbitraryArray.GetLength(0) - 1)
            j++;
            else if (i < j && i + j >= arbitraryArray.GetLength(0) - 1)
            i++;
            else if (i >= j && i + j > arbitraryArray.GetLength(0) - 1)
            j--;
            else
            i--;
        number++;
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

Console.WriteLine("Введите количество строк и столбцов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int values = 1;         // С данной цифры начинаем заполнять спираль. 

int[,] array = new int[size, size];

SpiralArray(array, values);
PrintArray(array);