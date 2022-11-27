// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FormArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = FormArray(count);

Console.Write("[" + string.Join(", ", array) + "]");


int counter = 0;
int EvenCount(int[] mass) 
{
        for(int i = 0; i < mass.Length; i++)
    {
            if(mass[i] % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

EvenCount(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел: {counter}");