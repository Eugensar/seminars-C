/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


void  point_of_intersection_of_lines (double b1, double k1, double b2, double k2)
{
    double resultX = 0;
    double resultY = 0;

    if (k1 == k2)
    {
        Console.WriteLine("прямые паралельны");
    }
    else
    {
        resultX = (b2 - b1) / (k1 - k2);
        resultY = ((k1 * b2) - (k2 * b1)) / (k1 - k2);
        Console.WriteLine($"точка пересечения - ({resultX}; {resultY})");

    }

}

Console.Write("Введите b1  ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1  ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2  ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2  ");
int k2 = Convert.ToInt32(Console.ReadLine());

point_of_intersection_of_lines(b1, k1, b2, k2);

