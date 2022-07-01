/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());


if(number == 7 || number == 6)
    Console.WriteLine("It's the Weekend! ");
else if (number >7 || number < 0)
    Console.WriteLine("No such day of the week! ");
else
    Console.WriteLine("It's weekday! ");
