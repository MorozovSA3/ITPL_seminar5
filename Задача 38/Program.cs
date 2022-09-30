// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetDoubleArray()
{
    Console.Write("Введите количество вещественных чисел в массиве: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (100 - (-100)) - 100, 2);
    }
    return array;
}

void PrintArray(double[] array)
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

void GetMaxMinDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i+1] > max) max = array[i+1];
        if (array[i+1] < min) min = array[i+1];
    }
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (max - min));
}

double[] array = GetDoubleArray();
PrintArray(array);
GetMaxMinDiff(array);