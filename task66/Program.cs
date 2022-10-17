/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

void PrintSumm(int M, int N, int summ)
{
  summ = summ + N;
  if (N <= M)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(M, N - 1, summ);
}

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
PrintSumm(M, N, 0);
