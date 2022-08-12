/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива.

[3,21 7,04 22,93 -2,71 78,24] -> 75,53
*/

Task38();
void Task38()
{
    int size = new Random().Next(4,6);
    double[] array = new double[size];
    Random randomDouble = new Random();
        
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-50,101) + Math.Round(randomDouble.NextDouble(),2);
    }
    Console.Write("массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    int j = 0;
    double maxNumber = array[j];
    double minNumber = array[j];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minNumber)
            {
                minNumber = array[i];
            }
        }
    Console.WriteLine($"максимальный элемент массива = {maxNumber}");
    Console.WriteLine($"минимальный элемент массива = {minNumber}");
    Console.WriteLine($"разница:{Math.Round((maxNumber-minNumber), 2)}");
}
