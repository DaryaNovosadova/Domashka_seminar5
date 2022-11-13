double Max(double arg1, double arg2, double arg3)
{
    double result1 = arg1;
    if(arg2 > result1) result1 = arg2;
    if(arg3 > result1) result1 = arg3;
    return result1;
}
double Min(double arg1, double arg2, double arg3)
{
    double result2 = arg1;
    if(arg2 < result2) result2 = arg2;
    if(arg3 < result2) result2 = arg3;
    return result2;
}
float[] GetArray(int size, int minValue, int maxValue)
{
    float[] res = new float[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
float[] array = GetArray(9, -100, 99);
Console.WriteLine();

double result1 = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

double result2 = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);

double result = result1 - result2;
Console.WriteLine(result);