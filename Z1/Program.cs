//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int num = int.Parse((Console.ReadLine()));

int GetFillRec(int num)
{
    if (num == 0) return 1;
    Console.WriteLine(num);
    int temp = GetFillRec(num-1);
    return temp;
}

GetFillRec(num);
