// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FormArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = FormArray(count);

Console.Write("[" + string.Join(", ", array) + "]");

int sum = 0;
int EvenCount(int[] mass) 
{
        for(int i = 1; i < mass.Length; i+=2)
    {
        sum = sum + mass[i];
    }
    return sum;
}

EvenCount(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях(индексах): {sum}");