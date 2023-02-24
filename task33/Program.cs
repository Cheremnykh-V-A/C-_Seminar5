// Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное
// число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomArray (int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange +1);
    }
    return array;
}

bool IsElementInArray(int[] array, int findNumber)
{
    bool result = false;
    for(int i = 0; i <array.Length; i++)
    {
        if (array[i] == findNumber)
        {
            result = true;
            break;
        }

    }
    return result;
}

int lenght = 12;
int leftRange = -9;
int rightRange = 9;
int finding = 5;

int[] myArray = GetRandomArray(lenght, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

bool res = IsElementInArray(myArray, finding);
Console.WriteLine(res);
