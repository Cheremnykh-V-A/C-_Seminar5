// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int ReadNumber (string messageToUser)
{
     Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray (int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange +1);
    }
    return array;
}

(int, int) SumPositiveAndNegativeElements(int [] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sumPositive = sumPositive + array[i];
            // sumPositive += array[i]
        }
        else if(array[i] < 0)
        {
            sumNegative += array[i];
        }
    }
    return (sumPositive, sumNegative);
}

int lenghtOfArray = ReadNumber("Введите длину массива");
int leftBoard = ReadNumber("Введите левую границу массива");
int rightBoard = ReadNumber("Введите праввую границу массива");

int[] myArray = GetRandomArray(lenghtOfArray, leftBoard, rightBoard);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

(int sumP, int sumN) = SumPositiveAndNegativeElements(myArray);
Console.WriteLine($"Сумма положительных элементов = {sumP}"); 
Console.WriteLine($"Сумма отрицательных элементов = {sumN}");