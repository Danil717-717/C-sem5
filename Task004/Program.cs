// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] CreateArray(int length, int min, int max)     // min и max для того чтобы заполн рандомно
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)                  // цикл заполнения массива 
    {
        array[i] = new Random().Next(min,max + 1);  // max+1 это чтоб max вошёл
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();    
           
}

int LineSegment(int[] arr)
{                                                  
    int num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] <= 99)
        {
            num++;
    
        }   
    }
    return num;
}


int [] array = CreateArray(123, 0, 124);                
PrintArray(array);
int num = LineSegment(array);
Console.WriteLine(num);