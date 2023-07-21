//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int M = int.Parse((Console.ReadLine()));

Console.WriteLine("Введите число N");
int N = int.Parse((Console.ReadLine()));

int GetSumNM(int M, int N)
{
    
    if (N==M) return N;
    int temp = N + GetSumNM(M, N-1);

    
    return temp;
    
    

}

int result = GetSumNM(M,N);
Console.WriteLine(result);
