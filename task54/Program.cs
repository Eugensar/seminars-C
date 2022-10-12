/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2  */

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] sortsArrayStringsDescendingOrder(int[,] Matrix)
{

    for (int j = 0; j < Matrix.GetLength(1); j++)
    {

        for (int i = 0; i < Matrix.GetLength(0); i++)
        {

            for (int k = 0; k < Matrix.GetLength(1) - 1; k++)
            {
                if (Matrix[i, k] < Matrix[i, k + 1])
                {
                    int temp = Matrix[i, k + 1];
                    Matrix[i, k + 1] = Matrix[i, k];
                    Matrix[i, k] = temp;

                }
            }

        }
    }
    return Matrix;
}

int[,] TwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("исходный масив:");
print2DArray(TwoDArray);
Console.WriteLine("отсортированный масив:");
sortsArrayStringsDescendingOrder(TwoDArray);
print2DArray(TwoDArray);


