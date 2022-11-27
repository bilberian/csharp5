// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [ 10, 11, 12, 13, 14 ] -> 5


int[] FormArray (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 1000);
    }
    return arr;
}

int[] array = FormArray(123);

Console.Write("[" + string.Join(", ", array) + "]");
Console.WriteLine();

int count = 0;
int Search (int[] mass) 
{
    for(int i = 0; i < mass.Length; i++)
    if(mass[i] >= 10 && mass[i] <= 99)
    count++;
    
    return count;
}

int result = Search(array);
Console.WriteLine();
Console.WriteLine($"количество: {result}");