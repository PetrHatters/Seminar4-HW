/*Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
int CountEvenNumbers(int[] array)
{
int count = 0;
foreach (var item in array)
{
    if( item%2==0) count ++;
}
return count;
}

int[] arr = GetRandomArray(8, 100, 1000);
Console.WriteLine(String.Join("; ", arr) + $" Четных чисел {CountEvenNumbers(arr)}");

