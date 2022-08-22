// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// функция заолнения массива
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

// функция подсчета положит чисел она будет возвращать результат
int FindPositiveSum(int[] arr)            //можно в функц передать еще аргумент bulean типа 
{                                         // чтоб в одной функции находить сумму полож и отрицат чисел 
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            sum += arr[i];
    }
    return sum;
}

// функция подсчета отрицат чисел она будет возвращать результат
int FindNegativeSum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}

// все функции готовы вызываем их
// CreateArray(12, -9, 9) - по условию (длинна массива, от -9, до 9)
// функция CreateArray создает массив поэтому этот массив нужно кудато записать
int [] array = CreateArray(12, -9, 9);                 //массив получен
PrintArray(array);
Console.WriteLine($"Сумма положительных элементов равна {FindPositiveSum(array)}");
Console.WriteLine($"Сумма положительных элементов равна {FindNegativeSum(array)}");
