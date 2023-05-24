// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

string Recursiya(int start, int end)
{
    if (start == end) return start.ToString();
    if (start > end)
    {
        return (start + " "+ Recursiya(start - 1, end));
    }
 return (start + " "+ Recursiya(start + 1, end));

}

System.Console.WriteLine(Recursiya(N, 1));