int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(6, 1, 100);
Console.WriteLine();

int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
Console.WriteLine($"сумма нечетных элементов {sum} ");
