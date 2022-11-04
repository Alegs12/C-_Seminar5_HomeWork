// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
//нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last+1);
    }
return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
        System.Console.WriteLine();
}

int SummEvenIndex(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i=i+2) summ += arr[i];
    return summ;
}

int[] arra= GetRandomArray(4, -10, 9);
PrintArray(arra);
System.Console.WriteLine(SummEvenIndex(arra));