/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
        printColorData(i+"\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i+"\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void arithmeticMeanColumn ( int[,] Matrix)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        double Mean = 0;
        
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {

            Mean += Matrix[i,j];

        }
        
        double Mean2 = Math.Round(Mean/Matrix.GetLength(0), 2);
        Console.Write(($" {Mean2} " ));
    }
}

int[,] TwoDArray = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

print2DArray(TwoDArray);
Console.Write("Среднее арифметическое каждого столбца:");
arithmeticMeanColumn (TwoDArray);


