/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
double[] arr = new double[] { 3.22, 4.2, 1.15, 77.15, 65.2 };
Console.WriteLine(Subtract(FindMin(arr), FindMax(arr)));

double Subtract(double minValue, double maxValue)
{

    double subtaction = maxValue - minValue;

    return subtaction;

}
double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}