/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

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

int array_input(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}


Console.Write("Введите кол-во элементов массива М: ");
int numberArray = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[numberArray];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:  ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
} 
printArray(Array);

Console.Write ($" чисел > 0 в массиве = {array_input(Array)}");







