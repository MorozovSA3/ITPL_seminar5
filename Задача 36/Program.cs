//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray()
{
    Console.Write("Введите количество чисел в массиве: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

void GetUnevenPosSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    Console.WriteLine("Сумма нечетных элементов массива: " + sum);
}

int[] array = GetArray();
PrintArray(array);
GetUnevenPosSum(array);