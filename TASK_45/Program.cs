/*
Задача 45: 
Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.
*/

int arrayLenght = new Random().Next(2, 30);

void FillArray(int[] array1)
{

    for (int i = 0; i < arrayLenght; i++)
    {
        array1[i] = new Random().Next(0, 1000);
    }

}

void CopyArray(int[] array2, int[] array3)
{
    for (int i = 0; i < arrayLenght; i++)
    {
        array3[i] = array2[i];
    }
}

void PrintArray(int[] array4)
{
    Console.Write("[");
    for (int i = 0; i < arrayLenght; i++)
    {
        Console.Write(array4[i]);
        if (i != arrayLenght-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


int [] array = new int [arrayLenght];
int [] copyArray = new int [arrayLenght];

FillArray(array);
CopyArray(array,copyArray);
Console.WriteLine("Оригинал массива");
Console.WriteLine("-------------------------------------------------- ");
PrintArray(array);
Console.WriteLine("Копия массива");
Console.WriteLine("-------------------------------------------------- ");
PrintArray(copyArray);