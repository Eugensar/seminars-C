/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В - степень");
int numberB = Convert.ToInt32(Console.ReadLine());
int degree = 1;

for (int i = 1; i <= numberB; i++)
{
    degree *= numberA;
}

Console.WriteLine($" Число А в степени В равно {degree}");
