/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/ 
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное значение для чисел: ");
double minValue = double.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для чисел: ");
double maxValue = double.Parse(Console.ReadLine());
int [,] matrix0 = GetRandomMatrix(rows,colums,minValue,maxValue);
int[,] GetRandomMatrix(int sizeM, int sizeN, double minValue, double maxValue)
{
    int[,] resultMatrix = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            resultMatrix[i,j] = new Random().NextDouble(minValue, maxValue + 1);
        }
    }

    return resultMatrix;
}
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write(" " + image[i,j]);
        }
        Console.WriteLine();
    }
}
PrintImage(matrix0);