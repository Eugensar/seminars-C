/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


int[] getRandomArray(int length)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(-10, 10);
    }
    return resultArray;
}

int getSumArray(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (i % 2 != 0)
        {
        result = incomingArray[i] + result;
        }
    }
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
int sum = getSumArray(getArray);
printArray(getArray);
Console.WriteLine($"Сумма чисел на нечетных позициях равно {sum}");