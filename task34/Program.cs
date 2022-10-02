﻿/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] getRandomArray(int length)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(100, 1000);
    }
    return resultArray;
}

int getSumEvenNumbersArray(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] % 2 == 0)
        {
            result += 1;
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
int sum = getSumEvenNumbersArray(getArray);
printArray(getArray);
Console.WriteLine($"Число четных чисел равно {sum}");