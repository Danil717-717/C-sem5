// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
        quantity++;
        }
    }
    return quantity;
}

int [] array = CreateArray(10, 100, 1000);
PrintArray(array);
Console.WriteLine();

int quantity = QuantityPositive(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");