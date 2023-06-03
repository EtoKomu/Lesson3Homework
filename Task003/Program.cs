// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.Write("Таблица кубов от 1 до введенного числа: ");
int index = 1;
while (index <= num)
{
    Console.Write(index * index * index + ", ");
    index += 1;
}