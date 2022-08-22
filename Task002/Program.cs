// Напишите программу замена элементов массива: положительные
//  элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] CreateArray(int length, int min, int max)     // min и max для того чтобы заполн рандомно
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)                  // цикл заполнения массива 
    {
        array[i] = new Random().Next(min,max + 1);  // max+1 это чтоб max вошёл
    }
    return array;
}

// функция для вывода массива, она будет принемать наш массив
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++ ) 
        Console.Write($"{array[i]} ");

    Console.WriteLine();    
           
}


void SignReplacPos(int[] arr)
{                                                  

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = -1 *arr[i];
    }

}


int [] array = CreateArray(8, -20, 20); 
PrintArray(array);
SignReplacPos(array);
PrintArray(array);
