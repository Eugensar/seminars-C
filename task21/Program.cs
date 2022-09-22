/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double getDistance() //int pointAX, int pointAY, int pointAZ, int pointBX, int pointBY, int pointBZ)
{
double distancce = 0;
Console.WriteLine("Введите координаты точки А  ");
int pointAX = Convert.ToInt32(Console.ReadLine());
int pointAY = Convert.ToInt32(Console.ReadLine());
int pointAZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки В  ");
int pointBX = Convert.ToInt32(Console.ReadLine());
int pointBY = Convert.ToInt32(Console.ReadLine());
int pointBZ = Convert.ToInt32(Console.ReadLine());

distancce = Math.Sqrt(Math.Pow(pointAX - pointBX, 2) + Math.Pow(pointAY - pointBY, 2) + Math.Pow(pointAZ - pointBZ, 2));
return distancce;
}

Console.WriteLine($" растояние между точками равно {getDistance()}");
