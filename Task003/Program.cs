//  Задайте массив. Напишите программу, которая определяет, 
//  присутствует ли заданное число в массиве.
//  4; массив [6, 7, 19, 345, 3] -> нет
//  3; массив [6, 7, 19, 345, 3] -> да

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

void ExamiNation(int[] arr, int num)
{                                                  
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
            Console.WriteLine("yes");
            return;
        }
        Console.WriteLine("no");
        return;    
    }

}

int number = new Random().Next(-10,10);
Console.WriteLine(number);
int [] array = CreateArray(12, -9, 9);                 //массив получен
PrintArray(array);
ExamiNation(array, number);


