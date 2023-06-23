/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр " + DigitSum(num));


int DigitSum(int number)
{
int sum = 0;
for (sum = 0; num>0;)
{
    sum += num%10;
    num /= 10;
}
return sum;
}



/*string input = Console.ReadLine();
int num = Convert.ToInt32(input);
int sum = 0;

int[] digits = new int[input.Length];
//Console.WriteLine("Пустой массив: " + string.Join(", ", digits));
for (int i = 0; i < digits.Length; i++)
{
    digits[i] = num%10;
    num /= 10;
}
//Console.WriteLine("Filled up массив цифр: " + string.Join(", ", digits));
for (int i = 0; i < digits.Length; i++)
{
    sum += digits[i];
}
Console.WriteLine("Сумма цифр из массива: " + sum);*/