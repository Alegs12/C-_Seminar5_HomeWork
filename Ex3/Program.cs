// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.[3 7 22 2 78] -> 76

double[] GetRandomArrayFrom0toLast(int size,int begin, int last)
{
    double[] arr = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(random.Next(begin*10, last*10) * 0.1, 2);
    }
return arr;
}

// random.NextDouble() * 5  // x = Math.Round(x, 2);

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
        System.Console.WriteLine();
}

double DeltaMaxMin(double[] arr)
{
    int i = 0;
    double res =0;
    double max = arr[i];
    double min = arr[i];

    for (i = 0; i < arr.Length; i++)
    {
       
       if (arr[i] > max) max = arr[i];
       if (arr[i] < min) min = arr[i];
    }
    res = max - min;
    return res;
}

double[] arr = GetRandomArrayFrom0toLast(5, 0, 100);
PrintArray(arr);
System.Console.WriteLine(DeltaMaxMin(arr));