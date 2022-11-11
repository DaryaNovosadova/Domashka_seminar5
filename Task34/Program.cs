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
int[] array = GetArray(6, 100, 999);
Console.WriteLine();

int count = 0;

foreach (int el in array)
{
    if (el %2 == 0)
    {
        count += 1;
    } 
}
Console.WriteLine($"Колличество четных чисел в данном массиве {count}" );
