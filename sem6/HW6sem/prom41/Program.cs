/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/ 
int length = ReadToInt("Введите кол-во: ");
int[] array;
array = MakeArray(length);
PrintArray(array);
Console.WriteLine($"Кол-во положительных чисел равно {CountPositive(array)}");


int ReadToInt (string request)
{
    System.Console.Write(request);
    string input = Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;
}
int[] MakeArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadToInt($"Введите {i+1}-й элемент: ");
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int CountPositive(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) counter++;
    }
    return counter;
}
