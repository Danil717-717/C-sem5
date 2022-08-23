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

int[] MultiPlic(int[] array) //создает новый массив
{
    int n;
    if(array.Length % 2 == 0) 
    {
        n = array.Length / 2;
    }    
    else 
    {
        n = array.Length / 2 + 1;
    }

    int [] newarray = new int[n];
    for(int i = 0; i < array.Length/2; i++)
    {
        newarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 != 0) newarray[array.Length / 2] = array[array.Length / 2];
    return newarray;
}




int[] myarr = CreateArray(10, 1, 100);
PrintArray(myarr);
int[] newarray = MultiPlic(myarr);
PrintArray(newarray);