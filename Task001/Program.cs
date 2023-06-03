// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int reversedNumber = 0;
int number1 = number;

while (number > 0)
    {
        int remainder = number % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        number = number / 10;
    }
if (number1 == reversedNumber)
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}