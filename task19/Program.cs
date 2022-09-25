/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */ 


int getСhangeling(int number)
{
int chang = 0;
while (number > 0)
{
     int numb = number % 10;
     chang = chang * 10 + numb;
     number = number / 10;
}
return chang;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = getСhangeling(number);
if (number == number1)
{
    Console.WriteLine($"число {number} является палиндромом");

}
else
    Console.WriteLine($"число {number} НЕ является палиндромом");


