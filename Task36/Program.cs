/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Task36();

void Task36()
{
    int size = new Random().Next(4, 6);
    int[] array = new int[size];
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        if (i %2 == 1)
        {
            sum += array[i];
        }
    }
    Console.WriteLine(sum);
}
