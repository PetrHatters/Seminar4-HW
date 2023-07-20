// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Console.WriteLine($"{result}");
Console.WriteLine("Введите позиции по оси Икс: ");
int inputX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позиции по оси Игрек: ");
int inputY = int.Parse(Console.ReadLine());
int[,] arr = {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4}
               };


int Value(int[,] array, int x, int y)
{
    int result = 0;
    if (inputX > arr.GetLength(0) || inputY > arr.GetLength(1)) Console.WriteLine($"Координаты больше длины массива.");
    else if (inputX < 0 || inputX < 0) Console.WriteLine($"Вводите положительные координаты.");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == inputX && j == inputY)
                {
                    result = array[i, j];
                }
            }
        }
    }
    return result;
}

Console.WriteLine($"{Value(arr, inputX, inputY)}");