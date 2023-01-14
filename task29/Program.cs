/* Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
 int[] GetArrayRandomNumber( int length, int start, int end)    
 {
    int[] arr = new int[length];
    for(int i = 0; i< length; i++)
    {
        arr[i] = new Random().Next( start, end + 1);
    }
    return arr;
 }
 
void showArrayElements(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
        Console.Write($"{array[i]},");
        }
        else
        {
           Console.Write($"{array[i]}]"); 
        }
    }
}
int[] array =  GetArrayRandomNumber(8,10,40);
showArrayElements(array);