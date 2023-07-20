// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Hello, World!");
int[,] arr = {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
               };
double[] sum = new double[arr.GetLength(1)];

PrintMatrix(arr);
Console.WriteLine();
PrintArray(sum);
Console.WriteLine();
PrintSumColums(arr);
Console.WriteLine();
PrintArray(sum);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" " + matrix[i,j]);
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i].ToString("0.00") + " ");
    }
}

void PrintSumColums (int[,] matx)
{
    for (int i = 0; i < matx.GetLength(1); i++)
    {
        for (int j = 0; j < matx.GetLength(0); j++)
        {
            Console.Write(matx[j,i] + " ");
            sum[i] += matx[j,i]/3.0;
        }
                    Console.WriteLine(matx.GetLength(0));
    }
}