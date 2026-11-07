int[] scores = { 60, 80, 40, 80, 90 };

System.Console.WriteLine(SumArray(scores));
Console.WriteLine(CountAtLeast(scores, 50));
Console.WriteLine(FindMin(scores));
Console.WriteLine(FindMax(scores));

int SumArray(int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}

int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}

int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}

int FindMin(int[] numbers)
{
    int min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}