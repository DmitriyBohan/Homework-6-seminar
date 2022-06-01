/*
Задача 44: 
Не используя рекурсию, выведите первые 
N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.WriteLine("Последовательность из скольки чисел Фибоначчи вы хотите получить?");
int FibNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {FibNumber} -> ");

void Fibonacci()
{
    int prev = 0;
    int current = 1;
    int temp;

    Console.Write(prev + " ");
    for (int i = 0; i <= FibNumber - 2; i++)
    {
        Console.Write(current + " ");
        temp = current;
        current = current + prev;
        prev = temp;
    }
}
Fibonacci();

