// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine();
Console.WriteLine("Массив :");
PrintArray(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int n = 0; n < array.GetLength(1) - 1; n++)
        {
             if (array[i, n] < array[i, n + 1])
            {
                int temp = 0;
                temp = array[i, n];
                array[i, n] = array[i, n + 1];
                array[i, n + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями:");
PrintArray(array);

void FillArray(int[,] arrayResult)
{
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            arrayResult[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] arrayResult)
{
    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            Console.Write(arrayResult[i, j] + " ");
        }
        Console.WriteLine();
    }
}