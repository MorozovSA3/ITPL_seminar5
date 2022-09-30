// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Get3DigitsArray()
{
    Console.Write("Введите количество трехзначных чисел в массиве: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
        if (i == array.Length - 1) Console.Write("]");
    }
    Console.WriteLine();
}

void CountEven(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + counter);
}

int[] array = Get3DigitsArray();
PrintArray(array);
CountEven(array);