// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FormArray (int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(10000)/100.00);
    }
    return arr;
}

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[] array = FormArray(count);

Console.Write("[" + string.Join(", ", array) + "]");

double diff = 0;
double DiffAmount(double[] mass)
    {
        double max = mass[0];
        double min = mass[0];
        for(int i = 0; i < mass.Length; i++)
        {
        
        if(mass[i] < min) min = mass[i];
        if(mass[i] > max) max = mass[i];
        }

        diff = max - min;
        return diff;
    }

double result = DiffAmount(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result}");
