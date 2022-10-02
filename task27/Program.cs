/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getDigitsNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        count = count + 1;
        number = number / 10;
    }
    return count;
}

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int numberLen = getDigitsNumber(userNumber);
int result = 0;
int variable = 0;

for(int i = 0; i <= numberLen; i++)
{
    variable = userNumber - userNumber % 10;
    result = result + (userNumber - variable);
    userNumber = userNumber / 10;
}

Console.WriteLine($"Сумма цифр в числе равнв = {result}");
