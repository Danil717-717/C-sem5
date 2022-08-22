// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



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

void MinMax(int[] array)
{                                                  
    int maxNumber = array[0];
    int minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
    if (minNumber > array[i])
    {
      minNumber = array[i];
    }
    }
    Console.WriteLine($"Максимальное число: {maxNumber}");
    Console.WriteLine($"Минимальное число: {minNumber}");
    Console.WriteLine($"Разница между {maxNumber} и {minNumber} равн {maxNumber - minNumber} ");
}

int [] array = CreateArray(10, 1, 100);
PrintArray(array);
Console.WriteLine();

MinMax(array);





