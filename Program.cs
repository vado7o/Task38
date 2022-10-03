// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Программа, показывающая разницу между максимальным и минимальным элементами массива.");

int size = 0;

while (true)
{
    Console.Write("\nНапишите - из скольки элементов должен состоять массив? : ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number > 0)
        {
            size = number;
            break;
        }
        else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
    }
    else Console.WriteLine("Некорректно указано количество элементов первого массива!\n");
}

int[] array = FillArray(size, 1, 100);
Console.Write("\nВ сгенерированном массиве");
PrintArray(array);
Console.WriteLine(" разница между максимальным и минимальным элементами равна " + CountDiff(array));


int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        filledArray[index] = new Random().Next(min, max);
    }
    return filledArray;
}

void PrintArray(int[] array)
{
    Console.Write(" [" + String.Join(", ", array) + "]");
}

int CountDiff(int[] array)
{
    int min = array[0];
    int max = array[0];
    int index = 1;

    while(index < size)
    {
        if(array[index] < min) min = array[index];
        else if(array[index] > max) max = array[index];
        index++;
    }
    int diff = max - min;
    return diff;
}