/* Задача 27: Напишите программу, 
которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int getUserMsg(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;  // выводит сообщение другого цвета
    Console.WriteLine(msg);
    Console.ResetColor();                            // сброс цвета
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}
int getNumberSum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10; 
        number = number / 10;
    }
    return sum;
}
void showResult(string messegeStart, int data)
{
    Console.Write(messegeStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;  // сообщение другого цвета будет
    Console.Write(data);
    Console.ResetColor();                             // сброс цвета 
}
int num = getUserMsg("Введите число");
int sum = getNumberSum(num);
showResult($"Сумма цифр в числе {num} = ", sum);