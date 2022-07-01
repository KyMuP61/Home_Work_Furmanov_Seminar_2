/*
Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/


Console.WriteLine("Enter number: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

/* if(number < 99)
    Console.WriteLine("Третьей цифры - нет!");
else
    Console.WriteLine(numberStr.ToCharArray()[2]); // работает при условии что число десятизначное или меньще
    */

if(number == 100 || number > 999)
{
    while(number>999){
        number = number/10;
    }
Console.WriteLine(number%10);
}
else 
{
    Console.WriteLine("Третьей цифры - нет!");
}
/* тоже не работает с числами больше чем десятизначные 8()- но это я уже где-то не до учил.
п.с. ...нашел: int	От -2 147 483 648 до 2 147 483 647	32-разрядное целое число со знаком
*/

