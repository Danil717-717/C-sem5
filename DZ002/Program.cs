// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] CreateArray(int length, int min, int max)     
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)                  
    {
        array[i] = new Random().Next(min, max);  
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();               
}

int SumNegative(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (i % 2 != 0)
        {
        quantity = quantity + array[i];
        }
    }
    return quantity;
}

int [] array = CreateArray(10, 1, 100);
PrintArray(array);
Console.WriteLine();

int sum = SumNegative(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");