/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


int[] getRandomArray(int length)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(0, 100);
    }
    return resultArray;
}

int differenceMaxMin(int[] incomingArray)
{
    int result = 0;
    int max = 0;
    int min = 100;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > max) max = incomingArray[i];
        if (incomingArray[i] < min) min = incomingArray[i];
    }
    result = max - min;
    return result;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите длину массива");
int lengtArray = Convert.ToInt32(Console.ReadLine());
int[] getArray = getRandomArray(lengtArray);
int dif = differenceMaxMin(getArray);
printArray(getArray);
Console.WriteLine($"разница между максимальным и минимальным элементов массива = {dif}");