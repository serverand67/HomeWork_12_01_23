/*Задача 25: Напишите цикл, который 
принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int getUserMsg(string msg)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;  // выводит сообщение другого цвета
    Console.WriteLine(msg);
    Console.ResetColor();                            // сброс цвета
    int messege = int.Parse(Console.ReadLine()!);
    return messege;
}

int getNumberExponentiation(int numA, int numB)
{
  int result = 1;
  for(int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
    return result;
}
int numA = getUserMsg("Введите число А");
int numB = getUserMsg("Введите число B");
int result = getNumberExponentiation(numA, numB);
Console.WriteLine($"Рузультат возведения числа А в степень В равен , {result}");