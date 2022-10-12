/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */

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

int[,] spiralArray(int dimensionOfArray)
{

    int[,] Matrix = new int[dimensionOfArray, dimensionOfArray];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= Matrix.GetLength(0) * Matrix.GetLength(1))
    {
        Matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < Matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= Matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > Matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    return Matrix;
}



Console.WriteLine("ВВедите размерность массива");
int dimensionOfArray = Convert.ToInt32(Console.ReadLine());
print2DArray(spiralArray(dimensionOfArray));

