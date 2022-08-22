// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] CreateArray(int length, int min, int max)     
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)                  
    {
        array[i] = new Random().Next(min,max + 1);  
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();    
           
}
// arr[0]*arr[arr.Length-1]
// arr[1]*arr[arr.Length-2]

int [] ProductPairsNumbersFif(int[] arr)
{
    int len = arr.Length;
    int new_len = 0;
    if(len % 2 == 0) 
    {
        new_len = new_len / 2;
    }    
    else 
    {
        new_len = len / 2 + 1;
    }

    int [] new_array = new int[new_len];

    for(int i = 0; i < new_len; i++)
    {
        new_array[i] = arr[i] * arr[len - 1 - i];
    }
    return new_array;
}

Console.Write("Введите желаемую длинну массива: ");
int len_array = Convert.ToInt32(Console.ReadLine());

int[] myarr = CreateArray(len_array, 1, 100);
PrintArray(myarr);
int[] narray = ProductPairsNumbersFif(myarr);
Console.Write(narray);