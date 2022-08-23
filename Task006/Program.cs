double [] CreateArray(int length, int min, int max)     
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)                  
    {
        array[i] = new Random().NextDouble()*(min - max) + min;
        array[i] = Math.Round(array[i], 2);  
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();               
}

double MinMax(double[] array)
{                                                  
    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i]) maxNumber = array[i];
        if (minNumber > array[i]) minNumber = array[i];
    }
    double dif = maxNumber - minNumber;
    return dif;
}

double [] array = CreateArray(10, 1, 100);
PrintArray(array);
Console.WriteLine();
double difference = MinMax(array);
Console.WriteLine($"sdf {difference} ");
