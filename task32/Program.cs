// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetRandomArray (int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange +1);
    }
    return array;
}

int lenght = 12;
int leftRange = -9;
int rightRange = 9;

int[] myArray = GetRandomArray(lenght, leftRange, rightRange);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
for(int i = 0; i < lenght; i++)
{
    myArray[i] = myArray[i] * -1;
}
Console.WriteLine($"[{string.Join(", ", myArray)}]");


